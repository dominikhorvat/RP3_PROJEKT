using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RP3_projekt
{
    public partial class FreezerControl : UserControl
    {
        string connectionString = ConfigurationManager
            .ConnectionStrings["BazaCaffeBar"].ConnectionString;

        BindingList<Item> items;

        public FreezerControl()
        {
            InitializeComponent();

            InitFreezerItems();
        }

        private void InitFreezerItems()
        {
            items = GetAllItems();

            freezerItemsView.AutoGenerateColumns = false;
            DataGridViewTextBoxColumn idColumn = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Id",
                HeaderText = "#"
            };
            DataGridViewTextBoxColumn nameColumn = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Name",
                HeaderText = "Artikl"
            };
            DataGridViewTextBoxColumn priceColumn = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Price",
                HeaderText = "Cijena\n(€)"
            };
            DataGridViewTextBoxColumn freezerQuantityColumn = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "FreezerQuantity",
                HeaderText = "Stanje\n(hladnjak)"
            };
            DataGridViewTextBoxColumn storageQuantityColumn = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "StorageQuantity",
                HeaderText = "Stanje\n(skladište)"
            };
            freezerItemsView.Columns.AddRange(idColumn, nameColumn, priceColumn, freezerQuantityColumn, storageQuantityColumn);
            
            freezerItemsView.DataSource = items;
        }

        private BindingList<Item> GetAllItems()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            SqlCommand command = new SqlCommand("SELECT * FROM Artikl", connection);

            BindingList<Item> itemsList = new BindingList<Item>();
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    itemsList.Add(new Item()
                    {
                        Id = (int)reader["id"],
                        Category = (ItemCategory)Enum.Parse(typeof(ItemCategory), (string)reader["category"]),
                        Name = (string)reader["name"],
                        Price = Convert.ToDecimal(reader["price"]),
                        FreezerQuantity = (int)reader["freezer_quantity"],
                        StorageQuantity = (int)reader["storage_quantity"]
                    });
                }
            }

            connection.Close();

            return itemsList;
        }

        private void addItemBtn_Click(object sender, EventArgs e)
        {
            if(freezerItemsView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Molimo odaberite artikl za nadopunu!");
                return;
            }
            Item item = (Item)freezerItemsView.SelectedRows[0].DataBoundItem;

            if(itemQuantity.Value != Math.Truncate(itemQuantity.Value))
            {
                MessageBox.Show("Neispravna količina artikla!");
                return;
            }
            int quantity = (int)itemQuantity.Value;
            if(quantity > item.StorageQuantity)
            {
                MessageBox.Show("Nedovoljna količina artikla u skladištu!");
                return;
            }

            item.FreezerQuantity += quantity;
            item.StorageQuantity -= quantity;

            updateItemInDb(item);
            freezerItemsView.Refresh();

            NotificationsService.CreateNotificationIfNeeded(item, NotificationLocation.STORAGE);
            NotificationsService.DeleteNotificationIfNeeded(item, NotificationLocation.FREEZER);
        }

        private void updateItemInDb(Item item)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            SqlCommand command = new SqlCommand("UPDATE Artikl SET freezer_quantity = @freezerQuantity, storage_quantity = @storageQuantity WHERE id = @itemId", connection);
            command.Parameters.AddWithValue("@freezerQuantity", item.FreezerQuantity);
            command.Parameters.AddWithValue("@storageQuantity", item.StorageQuantity);
            command.Parameters.AddWithValue("@itemId", item.Id);

            command.ExecuteNonQuery();

            connection.Close();
        }
    }
}
