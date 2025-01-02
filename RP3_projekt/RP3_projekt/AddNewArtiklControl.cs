using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RP3_projekt
{
    public partial class AddNewArtiklControl : UserControl
    {
        public AddNewArtiklControl()
        {
            InitializeComponent();
            PopuniPadajucuListu();
        }

        string connectionString = ConfigurationManager
           .ConnectionStrings["BazaCaffeBar"].ConnectionString;

        private void PopuniPadajucuListu()
        {
            string upit = "SELECT DISTINCT category FROM Artikl";
            List<string> kategorije = new List<string>();

            using (SqlConnection veza = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(upit, veza);
                veza.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    kategorije.Add(reader["category"].ToString());
                }
                reader.Close();
            }
            kategorije.Add("OTHER");

            comboBoxKategorija.Items.AddRange(kategorije.ToArray());
            comboBoxKategorija.SelectedIndex = -1;
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            //provjeri textbox za naziv
            if(textBoxNaziv.Text.Length == 0)
            {
                MessageBox.Show("Morate unijeti naziv novog artikla.");
                return;
            }

            //provjeri cijenu
            if (textBoxCijena.Text.Length == 0)
            {
                MessageBox.Show("Niste upisali cijenu novog artikla.");
                return;
            }

            string unos = textBoxCijena.Text.Trim();
            string ispravanOblik = @"^(?:[1-9]\d*|\d)(\,\d{1,2})?$";

            if (!Regex.IsMatch(unos, ispravanOblik))
            {
                MessageBox.Show("Unesite ispravan broj u odgovarajućem formatu." +
                                "\nZa oblik vidjeti u podkartici informacije.",
                                "Pogrešan oblik cijene",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            //provjeri combobox
            if (comboBoxKategorija.SelectedIndex == -1)
            {
                MessageBox.Show("Morate odabrati kategoriju artikla.");
                return;
            }

            //trebam naziv i kategoriju
            string naziv = textBoxNaziv.Text;
            string kategorija = comboBoxKategorija.SelectedItem.ToString();

            decimal cijena;
            if (decimal.TryParse(unos, NumberStyles.Any, new CultureInfo("hr-HR"), out cijena))
            {
                if (cijena == 0)
                {
                    MessageBox.Show("Cijena ne može biti jednaka nuli!",
                                    "Cijena je 0",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                    return;
                }

                insertNoviArtikl(naziv,cijena,kategorija);
            }
            else
            {
                MessageBox.Show("Unesite ispravan broj.",
                                "Neispravan unos",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }
            //MessageBox.Show("Sve je ok!");
        }

        private void insertNoviArtikl(string naziv, decimal cijena, string kategorija)
        {
            SqlConnection veza = new SqlConnection(connectionString);
            veza.Open();

            string upit = "INSERT INTO [Artikl]"
                + "(name,price,category) " +
                "VALUES(@name,@price,@category); SELECT SCOPE_IDENTITY();";
            SqlCommand naredba = new SqlCommand(upit, veza);
            naredba.Parameters.AddWithValue
                ("@name", naziv);
            naredba.Parameters.AddWithValue
                ("@price", cijena);
            naredba.Parameters.AddWithValue
                ("@category", kategorija);

            int artiklId = 0;
            try
            {
                artiklId = Convert.ToInt32(naredba.ExecuteScalar());
                MessageBox.Show("Dodali ste uspješno novi artikl!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            veza.Close();
            
            NotificationsService.CreateNotification(artiklId);
        }
    }
}
