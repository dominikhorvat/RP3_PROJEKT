﻿using System;
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

        //string za vezu s bazom
        string connectionString = ConfigurationManager
           .ConnectionStrings["BazaCaffeBar"].ConnectionString;

        private void PopuniPadajucuListu()
        {
            comboBoxKategorija.DataSource = new BindingSource(ItemCategoryUtility.itemCategoryTranslations, null);
            comboBoxKategorija.DisplayMember = "Value";
            comboBoxKategorija.ValueMember = "Key";
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

            //pomocu regularnog izraza provjeravamo unos
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
            if (comboBoxKategorija.SelectedValue == null)
            {
                MessageBox.Show("Morate odabrati kategoriju artikla.");
                return;
            }

            //trebam naziv i kategoriju
            string naziv = textBoxNaziv.Text;
            ItemCategory kategorija = (ItemCategory)comboBoxKategorija.SelectedValue;

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

                //ako je kod prošao dobro do ovog koraka preostaje još samo
                //prije inserta u tablicu provjeriti naziv artikla, to jest da ne budu
                //dva artikla istog naziva
                if (provjeriNazivArtikla(naziv) == 1)
                {
                    MessageBox.Show("Naziv unesenog artikla već postoji u bazi!");
                    return;
                }

                //sve je ok!
                //ubacimo artikl u odgovarajuću tablicu u bazi podataka
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
        }

        /// <summary>
        /// Metoda koja provjerava nazive artikala u bazi s unesenim novim artiklom
        /// </summary>
        /// <param name="naziv">Naziv novog artikla za koji se provjerava</param>
        /// <returns>Vraća 1 ako naziv artikla već postoji u bazi</returns>
        private int provjeriNazivArtikla(string naziv)
        {
            using (SqlConnection veza = new SqlConnection(connectionString))
            {
                veza.Open();

                string provjeraUpit = "SELECT COUNT(*) FROM [Artikl] WHERE name = @name";

                using (SqlCommand provjeraNaredba = new SqlCommand(provjeraUpit, veza))
                {
                    provjeraNaredba.Parameters.AddWithValue("@name", naziv);

                    int brojPostojecih = (int)provjeraNaredba.ExecuteScalar();

                    if (brojPostojecih > 0)
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>
        /// Ubacujemo novi artikl u odgovarajuću tablicu u bazi
        /// </summary>
        /// <param name="naziv">naziv novog artikla</param>
        /// <param name="cijena">cijena novog artikla</param>
        /// <param name="kategorija">odabrana kategorija novog artikla</param>
        private void insertNoviArtikl(string naziv, decimal cijena, ItemCategory kategorija)
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
                ("@category", kategorija.ToString());

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
