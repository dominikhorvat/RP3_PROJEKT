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
using static System.Windows.Forms.LinkLabel;

namespace RP3_projekt
{
    public partial class BillsControl : UserControl
    {
        string connectionString = ConfigurationManager
            .ConnectionStrings["BazaCaffeBar"].ConnectionString;

        private Employee currentEmployee;
        
        private BindingList<Item> selectedItems = new BindingList<Item>();
        private double totalPrice;

        public BillsControl(Employee currentEmployee)
        {
            InitializeComponent();

            this.currentEmployee = currentEmployee;

            InitBillsView(true);
        }

        private void InitBillsView(bool init)
        {
            InitAvailableItems();
            InitSelectedItems(init);
            employeeDiscount.Checked = false;
            InitPanelReturn();
        }

        private void InitAvailableItems()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            SqlCommand command = new SqlCommand("SELECT * FROM Artikl WHERE freezer_quantity > 0", connection);
            
            List<Item> items = new List<Item>();
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    items.Add(new Item()
                    {
                        Id = reader.GetInt32(0),
                        Name = reader.GetString(1),
                        Price = (double)reader.GetDecimal(2),
                        FreezerQuantity = reader.GetInt32(3),
                    });
                }

            }

            connection.Close();

            freezerItems.Items.Clear();
            foreach (Item item in items)
            {
                freezerItems.Items.Add(item);
            }
        }

        private void InitSelectedItems(bool init)
        {
            if (init)
            {
                selectedItemsView.AutoGenerateColumns = false;

                DataGridViewTextBoxColumn nameColumn = new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "Name",
                    HeaderText = "Artikl",
                    ReadOnly = true
                };
                DataGridViewTextBoxColumn priceColumn = new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "Price",
                    HeaderText = "Cijena (€)",
                    ReadOnly = true
                };
                DataGridViewTextBoxColumn selectedQuantityColumn = new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "SelectedQuantity",
                    HeaderText = "Količina",
                    ReadOnly = false
                };

                selectedItemsView.Columns.AddRange(nameColumn, priceColumn, selectedQuantityColumn);
                selectedItemsView.DataSource = selectedItems;
            } else
            {
                selectedItems.Clear();
                selectedItemsView.Refresh();
            }
        }

        private void InitPanelReturn()
        {
            panelReturn.Visible = false;
            billTotalPrice.Text = string.Empty;
            received.Text = string.Empty;
            forReturn.Text = string.Empty;
        }

        private void addItemBtn_Click(object sender, EventArgs e)
        {
            if(freezerItems.SelectedItems.Count == 0)
            {
                MessageBox.Show("Molimo odaberite artikl za dodavanje u račun!");
                return;
            }

            foreach (Item item in freezerItems.SelectedItems)
            {
                Item selectedItem = selectedItems.FirstOrDefault(i => i.Id == item.Id);
                if (selectedItem == null)
                {
                    selectedItem = item.Clone();
                    selectedItems.Add(selectedItem);
                }
                selectedItem.SelectedQuantity++;
                
            }

            selectedItemsView.Refresh();
        }

        private void deleteItemBtn_Click(object sender, EventArgs e)
        {
            if (selectedItemsView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Molimo odaberite red s artiklom ukoliko ga želite pobrisati!");
                return;
            }

            foreach (DataGridViewRow row in selectedItemsView.SelectedRows)
            {
                selectedItems.Remove((Item)row.DataBoundItem);
            }

            selectedItemsView.Refresh();
        }

        private void printBillBtn_Click(object sender, EventArgs e)
        {
            if (selectedItems.Count == 0)
            {
                MessageBox.Show("Molimo odaberite artikle za ispis računa!");
                return;
            }

            foreach (Item item in selectedItems)
            {
                if(item.SelectedQuantity > item.FreezerQuantity)
                {
                    MessageBox.Show($"Nije moguće dodati artikl '{item.Name}' u račun: nedovoljna količina artikla u hladnjaku! (traženo: {item.SelectedQuantity}, na stanju: {item.FreezerQuantity})");
                    return;
                }
                if (item.SelectedQuantity < 1)
                {
                    MessageBox.Show($"Nedopuštena količina artikla '{item.Name}'!");
                    return;
                }
            }

            totalPrice = Math.Round(selectedItems.Sum(i => i.Price * i.SelectedQuantity), 2);

            if (employeeDiscount.Checked)
            {
                totalPrice = Math.Round(totalPrice * 0.8, 2); // 20% popusta za račune na konobara
            }

            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            SqlCommand command = new SqlCommand("INSERT INTO Racun (zaposlenik_id, total_price) VALUES (@employeeId, @totalPrice); SELECT SCOPE_IDENTITY();", connection);
            command.Parameters.AddWithValue("@employeeId", currentEmployee.Id);
            command.Parameters.AddWithValue("@totalPrice", totalPrice);
            
            int billId = Convert.ToInt32(command.ExecuteScalar());

            foreach (Item item in selectedItems)
            {
                command = new SqlCommand("INSERT INTO StavkaRacuna (racun_id, artikl_id, quantity) VALUES (@billId, @itemId, @quantity)", connection);
                command.Parameters.AddWithValue("@billId", billId);
                command.Parameters.AddWithValue("@itemId", item.Id);
                command.Parameters.AddWithValue("@quantity", item.SelectedQuantity);
                command.ExecuteNonQuery();

                command = new SqlCommand("UPDATE Artikl SET freezer_quantity = freezer_quantity - @quantity WHERE id = @itemId", connection);
                command.Parameters.AddWithValue("@itemId", item.Id);
                command.Parameters.AddWithValue("@quantity", item.SelectedQuantity);
                command.ExecuteNonQuery();
            }

            connection.Close();

            // TODO ispiši račun
            
            ShowPanelReturn();
        }

        private void ShowPanelReturn()
        {
            panelReturn.Visible = true;
            billTotalPrice.Text = totalPrice.ToString();
        }

        private void calculateReturnBtn_Click(object sender, EventArgs e)
        {
            string receivedStr = received.Text;
            if (receivedStr == null || receivedStr.Length == 0)
            {
                MessageBox.Show("Molimo unesite koliko novaca je dao gost!");
                return;
            }
            double receivedNum;
            if (!double.TryParse(receivedStr, out receivedNum) || receivedNum <= 0 || receivedNum < totalPrice)
            {
                MessageBox.Show("Neispravan unos primljenog novca!");
                return;
            }

            forReturn.Text = Math.Round(receivedNum - totalPrice, 2).ToString();
        }

        private void finishBillBtn_Click(object sender, EventArgs e)
        {
            InitBillsView(false);
        }
    }
}
