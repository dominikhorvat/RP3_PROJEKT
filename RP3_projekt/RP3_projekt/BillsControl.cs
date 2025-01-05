using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace RP3_projekt
{
    public partial class BillsControl : UserControl
    {
        private string connectionString = ConfigurationManager
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

        #region Inicijalizacija prikaza
        private void InitBillsView(bool init)
        {
            InitAvailableItems();
            InitSelectedItems(init);
            InitDiscounts();
            InitPanelReturn();
        }

        /// <summary>
        /// Prikaz artikala koji se mogu dodati na račun (oni kojih ima u hladnjaku).
        /// </summary>
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
                        Price = Convert.ToDecimal(reader["price"]),
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

        /// <summary>
        /// Inicijalizacija tablice u kojoj se prikazuju artikli koji su dodani na račun.
        /// </summary>
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

        /// <summary>
        /// Inicijalizacija prikaza dostupnih popusta.
        /// Checkbox-evi za besplatne kave ili cijeđeni sok se prikazuju samo ako konobar već nije iskoristio tu pogodnost u smjeni.
        /// </summary>
        private void InitDiscounts()
        {
            employeeDiscount.Checked = false;

            freeCoffee.Checked = false;
            freeCoffee.Text = $"Iskoristi besplatnu kavu ( x{currentEmployee.Coffee} )";
            freeCoffee.Visible = currentEmployee.Coffee > 0;

            freeJuice.Checked = false;
            freeJuice.Text = $"Iskoristi besplatan cijeđeni sok ( x{currentEmployee.Juice} )";
            freeJuice.Visible = currentEmployee.Juice > 0;
        }

        /// <summary>
        /// Inicijalizacija panela gdje se računa koliko novaca treba vratiti gostu.
        /// Prikazuje se tek nakon ispisa računa.
        /// </summary>
        private void InitPanelReturn()
        {
            panelReturn.Visible = false;
            billTotalPrice.Text = string.Empty;
            received.Text = string.Empty;
            forReturn.Text = string.Empty;
        }
        #endregion

        #region Dodavanje/brisanje stavki računa
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
                if (selectedItem == null) // ako artikl već nije dodan, dodaje se, inače se samo povećava količina za 1
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
        #endregion

        #region Ispis računa
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

            DateTime time = DateTime.Now;

            decimal price = selectedItems.Sum(i => i.Price * i.SelectedQuantity);
            decimal totalPrice = price;

            List<Discount> discounts = new List<Discount>();
            byte usedFreeCoffee = 0, usedFreeJuice = 0; // inicijalizacija varijabli pomoću kojih se gleda treba li updateati tablicu 'Zaposlenik'
            CheckDiscounts(discounts, ref totalPrice, ref usedFreeCoffee, ref usedFreeJuice, time);

            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            // spremanje računa u bazu
            SqlCommand command = new SqlCommand("INSERT INTO Racun (zaposlenik_id, total_price, time) VALUES (@employeeId, @totalPrice, @time); SELECT SCOPE_IDENTITY();", connection);
            command.Parameters.AddWithValue("@employeeId", currentEmployee.Id);
            command.Parameters.AddWithValue("@totalPrice", totalPrice);
            command.Parameters.AddWithValue("@time", time);

            int billId = Convert.ToInt32(command.ExecuteScalar());

            foreach (Item item in selectedItems)
            {
                // spremanje stavke računa u bazu
                command = new SqlCommand("INSERT INTO StavkaRacuna (racun_id, artikl_id, quantity) VALUES (@billId, @itemId, @quantity)", connection);
                command.Parameters.AddWithValue("@billId", billId);
                command.Parameters.AddWithValue("@itemId", item.Id);
                command.Parameters.AddWithValue("@quantity", item.SelectedQuantity);
                command.ExecuteNonQuery();

                // update količine artikla u hladnjaku
                item.FreezerQuantity -= item.SelectedQuantity;
                command = new SqlCommand("UPDATE Artikl SET freezer_quantity = @freezerQuantity WHERE id = @itemId", connection);
                command.Parameters.AddWithValue("@itemId", item.Id);
                command.Parameters.AddWithValue("@freezerQuantity", item.FreezerQuantity);
                command.ExecuteNonQuery();

                NotificationsService.CreateNotificationIfNeeded(item, NotificationLocation.FREEZER);
            }

            if (usedFreeCoffee > 0 || usedFreeJuice > 0) // update iskorištenih besplatnih kava/cijeđenog soka zaposlenika
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

            PrintBill(); // ispis računa

            ShowPanelReturn(); // prikaz panela za računanje ostatka
        }

        private void CheckDiscounts(List<Discount> discounts, ref decimal totalPrice, ref byte usedFreeCoffee, ref byte usedFreeJuice, DateTime time)
        {
            CheckFreeItems(discounts, ref totalPrice, ref usedFreeCoffee, ref usedFreeJuice);
            CheckHappyHour(discounts, ref totalPrice, time);
            CheckEmployeeDiscount(discounts, ref totalPrice);
        }

        private void CheckFreeItems(List<Discount> discounts, ref decimal totalPrice, ref byte usedFreeCoffee, ref byte usedFreeJuice)
        {
            if (freeCoffee.Checked)
            {
                List<Item> selectedCoffees = new List<Item>();
                foreach (Item item in selectedItems)
                {
                    if(item.Category == ItemCategory.COFFEE)
                    {
                        for(int i = 0; i < item.SelectedQuantity; i++)
                        {
                            selectedCoffees.Add(item);
                        }
                    }
                }
                selectedCoffees.OrderBy(i => i.Price);

                // besplatna kava se koristi 1 ili 2 puta, ovisno je li zaposlenik iskoristio već kavu i koliko ih je dodao u račun
                // popust se koristi za kave s najmanjom cijenom na računu
                for (int i = 0; i < currentEmployee.Coffee; i++)
                {
                    if (i < selectedCoffees.Count)
                    {
                        Item freeCoffee = selectedCoffees[i];
                        discounts.Add(new Discount()
                        {
                            Name = "Besplatna kava",
                            Value = freeCoffee.Price,
                        });
                        totalPrice -= freeCoffee.Price;
                        freeCoffee.FreeCount++;
                        usedFreeCoffee++;
                    }
                    else
                    {
                        break;
                    }
                }
                currentEmployee.Coffee -= usedFreeCoffee;
            }

            if (freeJuice.Checked)
            {
                List<Item> selectedJuices = selectedItems.Where(i => i.Category == ItemCategory.FRESH_JUICE).ToList();

                // popust se koristi za 1 cijeđeni sok ako je dodan na račun, i to onaj s najmanjom cijenom
                if (selectedJuices.Count > 0)
                {
                    Item freeJuice = selectedJuices.OrderBy(i => i.Price).First();
                    discounts.Add(new Discount()
                    {
                        Name = "Besplatan cijeđeni sok",
                        Value = freeJuice.Price,
                    });
                    totalPrice -= freeJuice.Price;
                    freeJuice.FreeCount++;
                    usedFreeJuice++;
                    currentEmployee.Juice -= usedFreeJuice;
                }
            }
        }

        private void CheckHappyHour(List<Discount> discounts, ref decimal totalPrice, DateTime time)
        {
            if(totalPrice > 0)
            {
                List<HappyHour> happyHours = GetExistingHappyHours(time); // dohvat aktivnih happy hour popusta

                foreach (HappyHour happyHour in happyHours)
                {
                    Item item = selectedItems.FirstOrDefault(i => i.Id == happyHour.ItemId);
                    if (item != null)
                    {
                        for (int i = 0; i < item.SelectedQuantity - item.FreeCount; i++) // popust se primjenjuje na svaki artikl ukoliko ih ima više i za koji nije već iskorišten popust besplatna kava/cijeđeni sok
                        {
                            decimal discountValue = Math.Round(item.Price * (happyHour.Discount / 100), 2);
                            discounts.Add(new Discount()
                            {
                                Name = $"Happy hour {item.Name} {happyHour.Discount}%",
                                Value = discountValue
                            });
                            totalPrice -= discountValue;
                        }
                    }
                }
            }
        }

        private List<HappyHour> GetExistingHappyHours(DateTime time)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            SqlCommand command = new SqlCommand("SELECT * FROM HappyHour WHERE time_from <= @time AND time_until > @time", connection);
            command.Parameters.AddWithValue("@time", time);

            List<HappyHour> happyHours = new List<HappyHour>();
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    happyHours.Add(new HappyHour()
                    {
                        Id = (int)reader["id"],
                        ItemId = (int)reader["artikl_id"],
                        Discount = Convert.ToDecimal(reader["discount"]),
                        TimeFrom = (DateTime)reader["time_from"],
                        TimeUntil = (DateTime)reader["time_until"]
                    });
                }

            }

            connection.Close();

            return happyHours;
        }

        private void CheckEmployeeDiscount(List<Discount> discounts, ref decimal totalPrice)
        {
            if (employeeDiscount.Checked && totalPrice > 0) // popust ide na sve artikle u računu (i one koji su na happy hour popustu)
            {
                decimal discountValue = Math.Round(totalPrice * 0.20m, 2);
                discounts.Add(new Discount()
                {
                    Name = "Popust zaposlenika",
                    Value = discountValue
                });
                totalPrice -= discountValue;
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
            y += lineHeight * 2;

            e.Graphics.DrawString("vrijeme: " + bill.Time, font, Brushes.Black, x, y);
            y += lineHeight;
            e.Graphics.DrawString("izdao: '" + bill.Employee.Username + "'", font, Brushes.Black, x, y);
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

            e.Graphics.DrawString($"Ukupno: {bill.Price}€", new Font("Arial", 14, FontStyle.Bold), Brushes.Black, x + 300, y);
            y += lineHeight;
            foreach (Discount discount in bill.Discounts)
            {
                e.Graphics.DrawString($"{discount.Name}: -{discount.Value}€", new Font("Arial", 14, FontStyle.Bold), Brushes.Black, x + 300, y);
                y += lineHeight;
            }
            e.Graphics.DrawString($"Total: {bill.TotalPrice}€", new Font("Arial", 14, FontStyle.Bold), Brushes.Black, x + 300, y);
        }
        #endregion

        #region Računanje ostatka kojeg treba vratiti gostu
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
            decimal receivedNum;
            if (!decimal.TryParse(receivedStr, out receivedNum) || receivedNum <= 0 || receivedNum < bill.TotalPrice)
            {
                MessageBox.Show("Neispravan unos primljenog novca!");
                return;
            }

            forReturn.Text = Math.Round(receivedNum - bill.TotalPrice, 2).ToString();
        }
        #endregion

        private void finishBillBtn_Click(object sender, EventArgs e)
        {
            InitBillsView(false);
        }
    }
}
