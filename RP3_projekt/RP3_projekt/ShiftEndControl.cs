using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RP3_projekt
{
    public partial class ShiftEndControl : UserControl
    {
        private string connectionString = ConfigurationManager
            .ConnectionStrings["BazaCaffeBar"].ConnectionString;
        private Employee currentEmployee;
        private FormKonobar formKonobar;

        private BindingList<Bill> bills;
        private System.Windows.Forms.SortOrder billsSortOrder;
        private DataGridViewColumn billsSortColumn;

        private BindingList<Item> items;
        private System.Windows.Forms.SortOrder itemsSortOrder;
        private DataGridViewColumn itemsSortColumn;

        public ShiftEndControl(Employee currentEmployee, FormKonobar formKonobar)
        {
            InitializeComponent();

            this.currentEmployee = currentEmployee;
            this.formKonobar = formKonobar;

            PopulateShiftBills();
            PopulateShiftItems();
            PopulateTotal();
        }

        #region Prikaz računa koji su izdani u smjeni
        private void PopulateShiftBills()
        {
            shiftBillsLabel.Text = $"Računi izdani u smjeni (od {currentEmployee.LastLogin})";
            bills = GetShiftBills();

            shiftBillsView.AutoGenerateColumns = false;
            DataGridViewTextBoxColumn idColumn = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Id",
                HeaderText = "#"
            };
            DataGridViewTextBoxColumn timeColumn = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Time",
                HeaderText = "Vrijeme"
            };
            DataGridViewTextBoxColumn priceColumn = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "TotalPrice",
                HeaderText = "Cijena\n(€)"
            };
            shiftBillsView.Columns.AddRange(idColumn, timeColumn, priceColumn);

            shiftBillsView.DataSource = bills;
        }

        private BindingList<Bill> GetShiftBills()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            SqlCommand command = new SqlCommand("SELECT Racun.Id as billId, Racun.total_price as billTotalPrice, Racun.time as billTime," + 
                " Artikl.id as itemId, Artikl.name as itemName, Artikl.price as itemPrice, StavkaRacuna.quantity as itemQuantity" +
                " FROM Racun" + 
                " JOIN StavkaRacuna ON Racun.Id = StavkaRacuna.racun_id" +
                " JOIN Artikl ON StavkaRacuna.artikl_id = Artikl.id" +
                " WHERE time >= @loginTime", connection);
            command.Parameters.AddWithValue("@loginTime", currentEmployee.LastLogin);

            Dictionary<int, Bill> billsMap = new Dictionary<int, Bill>();
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    int billId = (int)reader["billId"];
                    
                    if (!billsMap.ContainsKey(billId))
                    {
                        billsMap[billId] = new Bill()
                        {
                            Id = billId,
                            Time = (DateTime)reader["billTime"],
                            TotalPrice = Convert.ToDecimal(reader["billTotalPrice"]),
                            Items = new List<Item>()
                        };
                    }

                    billsMap[billId].Items.Add(new Item()
                    {
                        Id = (int)reader["itemId"],
                        Name = (string)reader["itemName"],
                        Price = Convert.ToDecimal(reader["itemPrice"]),
                        SelectedQuantity = (int)reader["itemQuantity"]
                    });
                }
            }

            connection.Close();

            return new BindingList<Bill>(billsMap.Values.ToList());
        }
        #endregion

        #region Prikaz artikala koji su prodani u smjeni
        private void PopulateShiftItems()
        {
            shiftItemsLabel.Text = $"Artikli prodani u smjeni (od {currentEmployee.LastLogin})";
            items = GetShiftItems();

            shiftItemsView.AutoGenerateColumns = false;
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
            DataGridViewTextBoxColumn quantityColumn = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "SelectedQuantity",
                HeaderText = "Prodano komada"
            };
            shiftItemsView.Columns.AddRange(idColumn, nameColumn, priceColumn, quantityColumn);

            shiftItemsView.DataSource = items;
        }

        private BindingList<Item> GetShiftItems()
        {
            Dictionary<int, Item> shiftItems = new Dictionary<int, Item>();
            foreach (Bill bill in bills)
            {
                foreach (Item item in bill.Items)
                {
                    if (!shiftItems.ContainsKey(item.Id))
                    {
                        shiftItems[item.Id] = item.Clone();
                    }
                    else
                    {
                        shiftItems[item.Id].SelectedQuantity += item.SelectedQuantity;
                    }
                }
            }

            return new BindingList<Item>(shiftItems.Values.ToList());
        }
        #endregion

        #region Sortiranje tablica po stupcima
        private void shiftBillsView_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewColumn column = shiftBillsView.Columns[e.ColumnIndex];

            // defaultno sortiranje je uzlazno, osim ako već nije sortirano po istom stupcu
            if (billsSortColumn == column && billsSortOrder == System.Windows.Forms.SortOrder.Ascending)
            {
                billsSortOrder = System.Windows.Forms.SortOrder.Descending;
            } else
            {
                billsSortOrder = System.Windows.Forms.SortOrder.Ascending;
            }
            billsSortColumn = column;

            Func<Bill, object> func = null;
            switch (column.DataPropertyName)
            {
                case "Id":
                    func = bill => bill.Id;
                    break;
                case "Time":
                    func = bill => bill.Time;
                    break;
                case "TotalPrice":
                    func = bill => bill.TotalPrice;
                    break;
            }

            var sorted = billsSortOrder == System.Windows.Forms.SortOrder.Ascending ? bills.OrderBy(func).ToList() : bills.OrderByDescending(func).ToList();
            bills.Clear();
            foreach (var item in sorted)
            {
                bills.Add(item);
            }
            shiftBillsView.Refresh();
        }

        private void shiftItemsView_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewColumn column = shiftItemsView.Columns[e.ColumnIndex];

            if (itemsSortColumn == column && itemsSortOrder == System.Windows.Forms.SortOrder.Ascending)
            {
                itemsSortOrder = System.Windows.Forms.SortOrder.Descending;
            }
            else
            {
                itemsSortOrder = System.Windows.Forms.SortOrder.Ascending;
            }
            itemsSortColumn = column;

            Func<Item, object> func = null;
            switch (column.DataPropertyName)
            {
                case "Id":
                    func = item => item.Id;
                    break;
                case "Name":
                    func = item => item.Name;
                    break;
                case "Price":
                    func = item => item.Price;
                    break;
                case "SelectedQuantity":
                    func = item => item.SelectedQuantity;
                    break;
            }

            var sorted = itemsSortOrder == System.Windows.Forms.SortOrder.Ascending ? items.OrderBy(func).ToList() : items.OrderByDescending(func).ToList();
            items.Clear();
            foreach (var item in sorted)
            {
                items.Add(item);
            }
            shiftItemsView.Refresh();
        }
        #endregion

        private void PopulateTotal()
        {
            totalLabel.Text = $"Ukupna zarada: {bills.Sum(bill => bill.TotalPrice)}€";
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = CustomMessageBox.Show("Želite li se odjaviti iz aplikacije?",
                                   "Odjava");
            if (dialogResult == DialogResult.Yes)
            {
                //zaustavimo prvo timer, iako ne treba jer se odnosi samo na ovu formu, nije na odmet
                formKonobar.StopTimer();

                formKonobar.Close();
            }
        }
    }
}
