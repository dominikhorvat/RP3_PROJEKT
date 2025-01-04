using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace RP3_projekt
{
    class NotificationsService
    {
		private static string connectionString = ConfigurationManager
			.ConnectionStrings["BazaCaffeBar"].ConnectionString;
		private static int LOW_QUANTITY_LIMIT = 5; // obavijest kad je na stanju manje od 5 artikala

		private static List<Notification> _notifications = new List<Notification>();

		private static PictureBox notificationPictureBox = null;

		public static void Initialize(PictureBox pictureBox)
        {
			notificationPictureBox = pictureBox;
			_notifications = PopulateNotifications();
			toggleBtnVisibility();
		}

		public static List<Notification> GetAllNotifications()
		{
			return _notifications;
		}

		public static void CreateNotification(int itemId)
		{
			Item item = GetItem(itemId);
			CreateNotification(item, NotificationLocation.STORAGE);
			CreateNotification(item, NotificationLocation.FREEZER);
		}

		public static void CreateNotificationIfNeeded(Item item, NotificationLocation location)
		{
			if((location == NotificationLocation.STORAGE && item.StorageQuantity < LOW_QUANTITY_LIMIT) ||
					(location == NotificationLocation.FREEZER && item.FreezerQuantity < LOW_QUANTITY_LIMIT))
			{
				Notification notification = GetNotificationByItemIdAndLocation(item.Id, location);
				if (notification != null) {
					notification.Item = item;
				} else
				{
					CreateNotification(item, location);
					toggleBtnVisibility();
				}
			}
		}

		public static void DeleteNotificationIfNeeded(Item item, NotificationLocation location)
		{
			Notification notification = GetNotificationByItemIdAndLocation(item.Id, location);
			
			if (notification != null) {
				notification.Item = item;
				
				if((location == NotificationLocation.STORAGE && item.StorageQuantity >= LOW_QUANTITY_LIMIT) ||
					(location == NotificationLocation.FREEZER && item.FreezerQuantity >= LOW_QUANTITY_LIMIT))
				{
					DeleteNotification(notification);
					toggleBtnVisibility();
				}
			}
		}

		private static List<Notification> PopulateNotifications()
        {
			SqlConnection connection = new SqlConnection(connectionString);
			connection.Open();

			SqlCommand command = new SqlCommand("SELECT * FROM Obavijest JOIN Artikl ON Obavijest.artikl_id = Artikl.Id", connection);

			List<Notification> notificationsList = new List<Notification>();
			using (SqlDataReader reader = command.ExecuteReader())
			{
				while (reader.Read())
				{
					notificationsList.Add(new Notification()
					{
						Id = (int)reader["id"],
						Item = new Item()
						{
							Id = (int)reader["Id"],
							Category = (ItemCategory)Enum.Parse(typeof(ItemCategory), (string)reader["category"]),
							Name = (string)reader["name"],
							Price = Convert.ToDecimal(reader["price"]),
							FreezerQuantity = (int)reader["freezer_quantity"],
							StorageQuantity = (int)reader["storage_quantity"]
						},
						Location = (NotificationLocation)Enum.Parse(typeof(NotificationLocation), (string)reader["location"]),
						Time = (DateTime)reader["time"]
					});
				}
			}

			connection.Close();

			return notificationsList;
		}

		private static Notification GetNotificationByItemIdAndLocation(int itemId,  NotificationLocation location)
		{
			return _notifications.Find(n => n.Item.Id == itemId && n.Location == location);
		}

		private static void DeleteNotification(Notification notification) {
			SqlConnection connection = new SqlConnection(connectionString);
			connection.Open();

			SqlCommand command = new SqlCommand("DELETE FROM Obavijest WHERE id = @id", connection);
			command.Parameters.AddWithValue("@id", notification.Id);

			command.ExecuteNonQuery();

			connection.Close();

			_notifications.Remove(notification);
		}

		private static void CreateNotification(Item item, NotificationLocation location)
		{
			DateTime time = DateTime.Now;

			SqlConnection connection = new SqlConnection(connectionString);
			connection.Open();

			SqlCommand command = new SqlCommand("INSERT INTO Obavijest (artikl_id, location, time) VALUES (@itemId, @location, @time); SELECT SCOPE_IDENTITY();", connection);
			command.Parameters.AddWithValue("@itemId", item.Id);
			command.Parameters.AddWithValue("@location", location.ToString());
			command.Parameters.AddWithValue("@time", time);

			int notificationId = Convert.ToInt32(command.ExecuteScalar());

			connection.Close();

			_notifications.Add(new Notification
			{
				Id = notificationId,
				Item = item,
				Location = location,
				Time = time
			});
		}

		private static Item GetItem(int itemId)
		{
			SqlConnection connection = new SqlConnection(connectionString);
			connection.Open();

			SqlCommand command = new SqlCommand("SELECT * FROM Artikl WHERE Id = @itemId", connection);
			command.Parameters.AddWithValue("@itemId", itemId);

			Item item = null;
			using (SqlDataReader reader = command.ExecuteReader())
			{
				if (reader.Read())
				{
					item = new Item()
					{
						Id = (int)reader["Id"],
						Category = (ItemCategory)Enum.Parse(typeof(ItemCategory), (string)reader["category"]),
						Name = (string)reader["name"],
						Price = Convert.ToDecimal(reader["price"]),
						FreezerQuantity = (int)reader["freezer_quantity"],
						StorageQuantity = (int)reader["storage_quantity"]
					};
				}
			}

			connection.Close();

			return item;
		}

		private static void toggleBtnVisibility()
		{
			if(notificationPictureBox != null)
			{
				notificationPictureBox.Visible = _notifications.Count > 0;
			}
		}
	}
}
