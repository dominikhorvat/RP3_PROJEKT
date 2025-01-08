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
    public partial class HappyHourControl : UserControl
    {
        public HappyHourControl()
        {
            InitializeComponent();

            ReadArtikl();
            ReadArtiklHH();
        }

        string connectionString = ConfigurationManager
            .ConnectionStrings["BazaCaffeBar"].ConnectionString;

        /// <summary>
        /// Metoda koja puni data grid view svim artiklima koji se nalaze u tablici Artikl u bazi podataka
        /// </summary>
        private void ReadArtikl()
        {
            SqlConnection veza = new SqlConnection(connectionString); 

            veza.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Artikl", veza);

            DataTable dt = new DataTable(); 

            adapter.Fill(dt);

            dgvSviArtikli.SuspendLayout();

            dgvSviArtikli.DataSource = dt;

            dgvSviArtikli.Columns["id"].HeaderText = "#";
            dgvSviArtikli.Columns["category"].HeaderText = "Kategorija";
            dgvSviArtikli.Columns["name"].HeaderText = "Naziv artikla";
            dgvSviArtikli.Columns["price"].HeaderText = "Cijena (€)";
            dgvSviArtikli.Columns["freezer_quantity"].HeaderText = "Stanje hladnjaka";
            dgvSviArtikli.Columns["storage_quantity"].HeaderText = "Stanje skladišta";

            dgvSviArtikli.CellFormatting += (s, e) =>
            {
                if (dgvSviArtikli.Columns[e.ColumnIndex].Name == "category")
                {
                    ItemCategory itemCategory;
                    if (Enum.TryParse((string)e.Value, out itemCategory))
                    {
                        e.Value = ItemCategoryUtility.itemCategoryTranslations[itemCategory];
                        e.FormattingApplied = true;
                    }
                }
            };

            dgvSviArtikli.ResumeLayout();

            veza.Close();
        }

        /// <summary>
        /// Metoda koja puni data grid view svim artiklima koji se nalaze u tablici HappyHour u bazi podataka
        /// </summary>
        private void ReadArtiklHH()
        {
            SqlConnection veza = new SqlConnection(connectionString);

            veza.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT [artikl_id],[discount],[time_from],[time_until] FROM HappyHour", veza);

            DataTable dt = new DataTable(); 

            adapter.Fill(dt);

            dgvArtikliHH.SuspendLayout();

            dgvArtikliHH.DataSource = dt;

            dgvArtikliHH.Columns["artikl_id"].HeaderText = "ID artikla (#)";
            dgvArtikliHH.Columns["discount"].HeaderText = "Popust na happy hour-u (%)";
            dgvArtikliHH.Columns["time_from"].HeaderText = "Početak popusta";
            dgvArtikliHH.Columns["time_until"].HeaderText = "Kraj popusta";

            dgvArtikliHH.ResumeLayout();

            veza.Close();
        }

        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            // Provjera je li odabran barem jedan redak
            if (this.dgvSviArtikli.SelectedRows.Count == 0)
            {
                MessageBox.Show("Molimo odaberite red iz tablice.", 
                                "Greška", 
                                MessageBoxButtons.OK, 
                                MessageBoxIcon.Warning);
                return;
            }

            var selectedRow = this.dgvSviArtikli.SelectedRows[0];
            int idArtikla = Convert.ToInt32(selectedRow.Cells["Id"].Value);

            //ovdje provjera je li artikl već na happy hour-u -> pretpostavimo da može biti 
            //samo jedan u tablici za happy hour neovisno o vremenu!
            using (SqlConnection veza = new SqlConnection(connectionString)) //using da se veza automatski zatvori
            {
                veza.Open();

                string provjeraUpit = "SELECT COUNT(*) FROM [HappyHour] WHERE artikl_id = @artikl_id";
                using (SqlCommand provjeraNaredba = new SqlCommand(provjeraUpit, veza))
                {
                    provjeraNaredba.Parameters.AddWithValue("@artikl_id", idArtikla);

                    int brojPostojecih = (int)provjeraNaredba.ExecuteScalar();

                    if (brojPostojecih > 0)
                    {
                        MessageBox.Show("Artikl se već nalazi na happy hour-u, odaberite neki drugi!", "Postoji na happy hour-u");
                        return;
                    }
                }
            }

            decimal priceArtikl = Convert.ToDecimal(selectedRow.Cells["price"].Value);
            string nameArtikl = selectedRow.Cells["name"].Value.ToString();
            int freezerQuantity  = Convert.ToInt32(selectedRow.Cells["freezer_quantity"].Value);
            int storageQuantity  = Convert.ToInt32(selectedRow.Cells["storage_quantity"].Value);

            FormAddOnHappyHour prikaz = new FormAddOnHappyHour();

            //popunimo info one forme koja će se naknadno otvoriti (FormAddOnHappyHour.cs)
            prikaz.IdArtikla = idArtikla;
            prikaz.FillInfoArtikl(priceArtikl, nameArtikl, freezerQuantity, storageQuantity);

            //ako je operacija u formi uspješna, osvježuje se prikaz
            if (prikaz.ShowDialog() == DialogResult.OK)
            {
                ReadArtikl();
                ReadArtiklHH();
            }
        }

        private void buttonMakni_Click(object sender, EventArgs e)
        {
            //provjerimo za svaki slučaj ako nešto krene po krivu je li odabran redak
            if (dgvArtikliHH.CurrentRow == null || dgvArtikliHH.CurrentRow.Index == -1)
            {
                MessageBox.Show("Molimo odaberite valjani redak za brisanje.", 
                                "Greška", 
                                MessageBoxButtons.OK, 
                                MessageBoxIcon.Warning);
                return;
            }

            var val = this.dgvArtikliHH.SelectedRows[0].Cells[0].Value.ToString();
            if (val == null || val.Length == 0) return;

            int artiklIdHH = int.Parse(val);

            DialogResult dialogResult =
                CustomMessageBox.Show("Želite li sigurno maknuti artikl s happy\nhour-a?", 
                "Makni s happy hour-a");

            if (dialogResult == DialogResult.Yes)
            {
                //dialogResult == DialogResult.Yes -> mičemo artikl s Happy hour-a
                deleteFromHappyHour(artiklIdHH);

                ReadArtikl();
                ReadArtiklHH();
            }
        }

        /// <summary>
        /// Metoda koja briše artikl s happy hour-a
        /// </summary>
        /// <param name="idArtiklHH">Id artikla koji treba obrisati</param>
        private void deleteFromHappyHour(int idArtiklHH)
        {
            try
            {
                using (SqlConnection veza = new SqlConnection(connectionString))
                {
                    veza.Open();
                    string upit = "DELETE FROM HappyHour WHERE artikl_id=@id";
                    using (SqlCommand command = new SqlCommand(upit, veza))
                    {
                        {
                            command.Parameters.AddWithValue("@id", idArtiklHH);
                            command.ExecuteNonQuery();
                        }
                    }
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.ToString()); }
        }
    }
}
