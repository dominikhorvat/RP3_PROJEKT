﻿using System;
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
    public partial class StorageControl : UserControl
    {
        private string connectionString = ConfigurationManager
            .ConnectionStrings["BazaCaffeBar"].ConnectionString;

        private BindingList<Item> items;

        public StorageControl()
        {
            InitializeComponent();

            InitStorageItems();
        }

        #region Inicijalizacija prikaza artikala u skladištu
        private void InitStorageItems()
        {
            items = GetAllItems();

            storageItemsView.AutoGenerateColumns = false;
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
            DataGridViewTextBoxColumn storageQuantityColumn = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "StorageQuantity",
                HeaderText = "Stanje\n(skladište)"
            };
            storageItemsView.Columns.AddRange(idColumn, nameColumn, priceColumn, storageQuantityColumn);

            storageItemsView.DataSource = items;
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
        #endregion

        #region Nadopuna artikla u skladištu
        private void addItemBtn_Click(object sender, EventArgs e)
        {
            if (storageItemsView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Molimo odaberite artikl za nadopunu!");
                return;
            }
            Item item = (Item)storageItemsView.SelectedRows[0].DataBoundItem;

            if (itemQuantity.Value != Math.Truncate(itemQuantity.Value))
            {
                MessageBox.Show("Neispravna količina artikla!");
                return;
            }
            int quantity = (int)itemQuantity.Value;

            item.StorageQuantity += quantity;

            updateItemInDb(item);
            storageItemsView.Refresh();
            
            NotificationsService.DeleteNotificationIfNeeded(item, NotificationLocation.STORAGE);
        }

        private void updateItemInDb(Item item)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            SqlCommand command = new SqlCommand("UPDATE Artikl SET storage_quantity = @storageQuantity WHERE id = @itemId", connection);
            command.Parameters.AddWithValue("@storageQuantity", item.StorageQuantity);
            command.Parameters.AddWithValue("@itemId", item.Id);

            command.ExecuteNonQuery();

            connection.Close();
        }
        #endregion
    }
}
