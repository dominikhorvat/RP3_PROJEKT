using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
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
        private Bill bill;

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
            InitDiscounts();
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
                        Id = (int)reader["id"],
                        Category = (ItemCategory)Enum.Parse(typeof(ItemCategory), (string)reader["category"]),
                        Name = (string)reader["name"],
                        Price = Convert.ToDouble(reader["price"]),
                        FreezerQuantity = (int)reader["freezer_quantity"]
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
            }
            else
            {
                selectedItems.Clear();
                selectedItemsView.Refresh();
            }
        }

        private void InitDiscounts()
        {
            employeeDiscount.Checked = false;

            freeCoffee.Checked = false;
            freeCoffee.Visible = currentEmployee.Coffee > 0;

            freeJuice.Checked = false;
            freeJuice.Visible = currentEmployee.Juice > 0;
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
            if (freezerItems.SelectedItems.Count == 0)
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
                if (item.SelectedQuantity > item.FreezerQuantity)
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

            double price = Math.Round(selectedItems.Sum(i => i.Price * i.SelectedQuantity), 2);
            double totalPrice = price;

            List<Discount> discounts = new List<Discount>();
            bool shouldUpdateFreeItems = false;
            SetDiscounts(discounts, ref shouldUpdateFreeItems, ref totalPrice);

            DateTime time = DateTime.Now;

            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            SqlCommand command = new SqlCommand("INSERT INTO Racun (zaposlenik_id, total_price, time) VALUES (@employeeId, @totalPrice, @time); SELECT SCOPE_IDENTITY();", connection);
            command.Parameters.AddWithValue("@employeeId", currentEmployee.Id);
            command.Parameters.AddWithValue("@totalPrice", totalPrice);
            command.Parameters.AddWithValue("@time", time);

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

            if (shouldUpdateFreeItems)
            {
                command = new SqlCommand("UPDATE Zaposlenik SET coffee = @coffee, juice = @juice WHERE id = @employeeId", connection);
                command.Parameters.AddWithValue("@employeeId", currentEmployee.Id);
                command.Parameters.AddWithValue("@coffee", currentEmployee.Coffee);
                command.Parameters.AddWithValue("@juice", currentEmployee.Juice);
                command.ExecuteNonQuery();
            }

            connection.Close();

            bill = new Bill()
            {
                Id = billId,
                Time = time,
                Employee = currentEmployee,
                Items = selectedItems.ToList(),
                Price = price,
                TotalPrice = totalPrice,
                Discounts = discounts
            };

            PrintBill();

            ShowPanelReturn();
        }

        private void SetDiscounts(List<Discount> discounts, ref bool shouldUpdateFreeItems, ref double totalPrice)
        {
            if (freeCoffee.Checked)
            {
                List<Item> selectedCoffees = selectedItems.Where(i => i.Category == ItemCategory.COFFEE)
                                    .OrderBy(i => i.Price)
                                    .ToList();

                for (int i = 0; i < currentEmployee.Coffee; i++)
                {
                    if (i < selectedCoffees.Count)
                    {
                        discounts.Add(new Discount()
                        {
                            Name = "Besplatna kava",
                            type = DiscountType.FREE_ITEM,
                            Value = selectedCoffees[i].Price
                        });
                        totalPrice -= selectedCoffees[i].Price;
                        currentEmployee.Coffee--;
                        shouldUpdateFreeItems = true;
                    }
                    else
                    {
                        break;
                    }
                }
            }

            if (freeJuice.Checked)
            {
                List<Item> selectedJuices = selectedItems.Where(i => i.Category == ItemCategory.FRESH_JUICE).ToList();

                if (selectedJuices.Count > 0)
                {
                    double discountValue = selectedJuices.Min(i => i.Price);
                    discounts.Add(new Discount()
                    {
                        Name = "Besplatan cijeđeni sok",
                        type = DiscountType.FREE_ITEM,
                        Value = discountValue
                    });
                    totalPrice -= discountValue;
                    currentEmployee.Juice--;
                    shouldUpdateFreeItems = true;
                }
            }

            if (employeeDiscount.Checked && totalPrice > 0)
            {
                discounts.Add(new Discount()
                {
                    Name = "Popust zaposlenika",
                    type = DiscountType.DISCOUNT,
                    Value = 0.2
                });
                totalPrice = Math.Round(totalPrice * 0.8, 2);
            }
        }

        private void PrintBill()
        {
            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += PrintDocument_PrintPage;

            PrintPreviewDialog previewDialog = new PrintPreviewDialog
            {
                Document = printDocument
            };
            previewDialog.StartPosition = FormStartPosition.CenterParent;
            previewDialog.Height = 600;
            previewDialog.Width = 600;
            previewDialog.PrintPreviewControl.Zoom = 0.75;
            previewDialog.ShowDialog();
        }

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            Font font = new Font("Arial", 12);
            float lineHeight = font.GetHeight(e.Graphics);
            float x = 100;
            float y = 100;

            e.Graphics.DrawString($"Račun #{bill.Id}", new Font("Arial", 16, FontStyle.Bold), Brushes.Black, x, y);
            y += lineHeight;

            e.Graphics.DrawString("Izdao '" + bill.Employee.Username + "' u " + bill.Time, font, Brushes.Black, x, y);
            y += lineHeight * 2;

            e.Graphics.DrawString("Artikl", new Font(font, FontStyle.Bold), Brushes.Black, x, y);
            e.Graphics.DrawString("Cijena", new Font(font, FontStyle.Bold), Brushes.Black, x + 200, y);
            e.Graphics.DrawString("Količina", new Font(font, FontStyle.Bold), Brushes.Black, x + 300, y);
            e.Graphics.DrawString("Total", new Font(font, FontStyle.Bold), Brushes.Black, x + 400, y);
            y += lineHeight;

            foreach (Item item in bill.Items)
            {
                e.Graphics.DrawString(item.Name, font, Brushes.Black, x, y);
                e.Graphics.DrawString(item.Price.ToString("F2"), font, Brushes.Black, x + 200, y);
                e.Graphics.DrawString(item.SelectedQuantity.ToString(), font, Brushes.Black, x + 300, y);
                e.Graphics.DrawString((item.Price * item.SelectedQuantity).ToString("F2"), font, Brushes.Black, x + 400, y);
                y += lineHeight;
            }
            y += lineHeight;

            e.Graphics.DrawString($"Ukupno: {bill.Price:F2}€", new Font("Arial", 14, FontStyle.Bold), Brushes.Black, x + 300, y);
            y += lineHeight;
            foreach (Discount discount in bill.Discounts)
            {
                double discountValue = 0;
                if (discount.type == DiscountType.DISCOUNT)
                {
                    discountValue = Math.Round(bill.Price * discount.Value, 2);
                }
                else if (discount.type == DiscountType.FREE_ITEM)
                {
                    discountValue = discount.Value;
                }

                e.Graphics.DrawString($"{discount.Name}: -{discountValue}€", new Font("Arial", 14, FontStyle.Bold), Brushes.Black, x + 300, y);
                y += lineHeight;
            }
            e.Graphics.DrawString($"Total: {bill.TotalPrice:F2}€", new Font("Arial", 14, FontStyle.Bold), Brushes.Black, x + 300, y);
        }

        private void ShowPanelReturn()
        {
            panelReturn.Visible = true;
            billTotalPrice.Text = bill.TotalPrice.ToString();
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
            if (!double.TryParse(receivedStr, out receivedNum) || receivedNum <= 0 || receivedNum < bill.TotalPrice)
            {
                MessageBox.Show("Neispravan unos primljenog novca!");
                return;
            }

            forReturn.Text = Math.Round(receivedNum - bill.TotalPrice, 2).ToString();
        }

        private void finishBillBtn_Click(object sender, EventArgs e)
        {
            InitBillsView(false);
        }
    }
}
