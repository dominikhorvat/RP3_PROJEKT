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
using System.Windows.Forms.DataVisualization.Charting;

namespace RP3_projekt
{
    public partial class ConsuptionControl : UserControl
    {

        private FormConsuption prikazPotrosnje; //forma za prikaz prodanih artikala u odabranom razdoblju
        private FormAllTimeConsuption prikazSvePotrosnje; //forma za prikaz cjelokupne potrosnje neovisno o razdoblju

        public ConsuptionControl()
        {
            InitializeComponent();

            ispuniPadajucuListuArtiklima();
        }

        //string za vezu s bazom
        string connectionString = ConfigurationManager
           .ConnectionStrings["BazaCaffeBar"].ConnectionString;

        /// <summary>
        /// Metoda koja ispunjava padajući izbornik artiklima iz tablice Artikl
        /// </summary>
        private void ispuniPadajucuListuArtiklima()
        {
            string upit = "SELECT DISTINCT name FROM Artikl";
            List<string> naziv = new List<string>();

            using (SqlConnection veza = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(upit, veza);
                veza.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    naziv.Add(reader["name"].ToString());
                }
                reader.Close();
            }

            comboBoxArtikl.Items.AddRange(naziv.ToArray());
            comboBoxArtikl.SelectedIndex = 0;
        }

        private void buttonPrikazi_Click(object sender, EventArgs e)
        {
            //za svaki slucaj provjera ako nešto pođe po krivu
            if (comboBoxArtikl.SelectedItem == null)
            {
                MessageBox.Show("Morate odabrati kategoriju artikla.");
                return;
            }

            string nazivArtikla = comboBoxArtikl.SelectedItem.ToString();

            //provjera je li datum pocetka strogo veći od datuma zavrsetka
            DateTime pocetniDatum = monthCalendarPocetak.SelectionRange.Start;
            DateTime zavrsniDatum = monthCalendarKraj.SelectionRange.Start;

            if (pocetniDatum > zavrsniDatum)
            {
                MessageBox.Show("Početni datum ne može biti veći od završnog!", "Greška u datumu!");
                return;
            }

            ispuniPrikaz(nazivArtikla, pocetniDatum, zavrsniDatum);
            ispuniLabeluUkupnaPotrosnja(nazivArtikla, pocetniDatum, zavrsniDatum);

            ispuniNajviseProdaniArtikl(pocetniDatum, zavrsniDatum);
            //ispuniNajmanjeProdaniArtikl(pocetniDatum, zavrsniDatum);
        }

        /// <summary>
        /// Metoda koja ispuni chart
        /// </summary>
        /// <param name="naziv">Naziv proizvoda kojeg želimo prikazati</param>
        /// <param name="pocetak">Početni datum s Month Calendar</param>
        /// <param name="kraj">Krajnji datum s Month Calendar</param>
        private void ispuniPrikaz(string naziv, DateTime pocetak, DateTime kraj)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string upit = @"
                SELECT 
                    CONVERT(DATE, Racun.time) AS Datum, 
                    SUM(StavkaRacuna.quantity) AS Kolicina
                FROM 
                    StavkaRacuna
                INNER JOIN 
                    Racun ON StavkaRacuna.racun_id = Racun.Id
                INNER JOIN 
                    Artikl ON StavkaRacuna.artikl_id = Artikl.Id
                WHERE 
                    Artikl.name = @NazivArtikla 
                    AND CONVERT(DATE, Racun.time) >= @DatumPocetka 
                    AND CONVERT(DATE, Racun.time) <= @DatumKraja
                GROUP BY 
                    CONVERT(DATE, Racun.time)
                ORDER BY 
                    Datum";

                using (SqlCommand cmd = new SqlCommand(upit, connection))
                {
                    cmd.Parameters.AddWithValue("@NazivArtikla",naziv);
                    cmd.Parameters.AddWithValue("@DatumPocetka",pocetak);
                    cmd.Parameters.AddWithValue("@DatumKraja",kraj);

                    connection.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        chartPotrosnjaArtikla.Series.Clear();

                        Series series = new Series("Količina za '" + naziv + "'");
                        series.ChartType = SeriesChartType.Column;
                        chartPotrosnjaArtikla.Series.Add(series);

                        while (reader.Read())
                        {
                            DateTime datum = reader.GetDateTime(0);
                            int kolicina = reader.GetInt32(1);
                            series.Points.AddXY(datum.ToShortDateString(), kolicina);
                        }
                    }

                }
            }
        }

        /// <summary>
        /// Metoda koja ispunjava labelu koja ukazuje na to koliko je ukupno prodano odabaranog artikla u odabranom razdoblju
        /// </summary>
        /// <param name="naziv">Naziv artikla za koleg želimo ukupnu količinu</param>
        /// <param name="pocetak">Početni datum</param>
        /// <param name="kraj">Završni datum</param>
        private void ispuniLabeluUkupnaPotrosnja(string naziv, DateTime pocetak, DateTime kraj)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string upit = @"
                SELECT 
                    CONVERT(DATE, r.time) AS Datum, 
                    SUM(sr.quantity) AS UkupnoKolicina
                FROM 
                    StavkaRacuna sr
                INNER JOIN 
                    Artikl a ON sr.artikl_id = a.Id
                INNER JOIN 
                    Racun r ON sr.racun_id = r.Id
                WHERE 
                    CONVERT(DATE, r.time) BETWEEN CONVERT(DATE, @DatumPocetka) 
                    AND CONVERT(DATE, @DatumKraja)
                    AND a.name = @NazivArtikla
                GROUP BY 
                    CONVERT(DATE, r.time)
                ORDER BY 
                    Datum";

                using (SqlCommand cmd = new SqlCommand(upit, connection))
                {
                    cmd.Parameters.AddWithValue("@DatumPocetka", pocetak);
                    cmd.Parameters.AddWithValue("@DatumKraja", kraj);
                    cmd.Parameters.AddWithValue("@NazivArtikla", naziv);

                    connection.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        int ukupnaKolicina = 0;

                        while (reader.Read())
                        {
                            if (reader["UkupnoKolicina"] != DBNull.Value)
                            {
                                ukupnaKolicina += Convert.ToInt32(reader["UkupnoKolicina"]);
                            }
                        }

                        if (ukupnaKolicina > 0)
                        {
                            labelUkupnaPotrosnja.Text = $"Artikl '{naziv}' je prodan {ukupnaKolicina} puta u odabranom razdoblju.";
                        }
                        else
                        {
                            labelUkupnaPotrosnja.Text = $"Artikl '{naziv}' nije prodan u odabranom razdoblju.";
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Metoda koja prikazuje najviše prodani artikl u odabranom vremenu
        /// </summary>
        /// <param name="pocetak">Početni datum</param>
        /// <param name="kraj">Završni datum</param>
        private void ispuniNajviseProdaniArtikl(DateTime pocetak, DateTime kraj)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string upit = @"
                SELECT 
                    a.name AS Artikl, 
                    SUM(sr.quantity) AS UkupnoKolicina
                FROM 
                    StavkaRacuna sr
                INNER JOIN 
                    Artikl a ON sr.artikl_id = a.Id
                INNER JOIN 
                    Racun r ON sr.racun_id = r.Id
                WHERE 
                    CONVERT(DATE, r.time) BETWEEN CONVERT(DATE, @DatumPocetka) AND CONVERT(DATE, @DatumKraja)
                GROUP BY 
                    a.name
                ORDER BY 
                    UkupnoKolicina DESC";

                using (SqlCommand cmd = new SqlCommand(upit, connection))
                {
                    cmd.Parameters.AddWithValue("@DatumPocetka", pocetak);
                    cmd.Parameters.AddWithValue("@DatumKraja", kraj);

                    connection.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string najprodavanijiArtikl = reader["Artikl"].ToString();
                            int najprodavanijaKolicina = Convert.ToInt32(reader["UkupnoKolicina"]);
                            labelNajviseProdani.Text = $"Najprodavaniji artikl je '{najprodavanijiArtikl}' s količinom {najprodavanijaKolicina}.";
                        }
                    }
                }
            }
        }

        private void buttonPrikazProdanih_Click(object sender, EventArgs e)
        {
            //provjera je li datum pocetka strogo veći od datuma zavrsetka
            DateTime pocetniDatum = monthCalendarPocetak.SelectionRange.Start;
            DateTime zavrsniDatum = monthCalendarKraj.SelectionRange.Start;

            if (pocetniDatum > zavrsniDatum)
            {
                MessageBox.Show("Početni datum ne može biti veći od završnog!", "Greška u datumu!");
                return;
            }

            if (prikazPotrosnje == null || prikazPotrosnje.IsDisposed) //ako forma ne postoji stvori ju
            {
                prikazPotrosnje = new FormConsuption();
            }
            
            prikazPotrosnje.PopuniTablicuPotrosnje(pocetniDatum, zavrsniDatum);
            prikazPotrosnje.ShowDialog();
        }

        private void buttonCijeloVrijeme_Click(object sender, EventArgs e)
        {

            if (prikazSvePotrosnje == null || prikazSvePotrosnje.IsDisposed) //ako forma ne postoji stvori ju
            {
                prikazSvePotrosnje = new FormAllTimeConsuption();
            }

            prikazSvePotrosnje.PopuniTablicuSvePotrosnje();
            prikazSvePotrosnje.ShowDialog();
        }
    }
}
