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
    public partial class ManagementControl : UserControl
    {
        public ManagementControl()
        {
            InitializeComponent();
            ReadArtikl();
        }

        //string za vezu s bazom
        string connectionString = ConfigurationManager
           .ConnectionStrings["BazaCaffeBar"].ConnectionString;

        /// <summary>
        /// Pročita sve artikle iz tablice i popuni data grid view
        /// </summary>
        private void ReadArtikl()
        {
            SqlConnection veza = new SqlConnection(connectionString);

            veza.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Artikl", veza);

            DataTable dt = new DataTable();

            adapter.Fill(dt);

            dataGridViewChangePrice.SuspendLayout();

            dataGridViewChangePrice.DataSource = dt;

            dataGridViewChangePrice.Columns["id"].HeaderText = "#";
            dataGridViewChangePrice.Columns["category"].HeaderText = "Kategorija";
            dataGridViewChangePrice.Columns["name"].HeaderText = "Naziv artikla";
            dataGridViewChangePrice.Columns["price"].HeaderText = "Cijena (€)";
            dataGridViewChangePrice.Columns["freezer_quantity"].HeaderText = "Stanje hladnjaka";
            dataGridViewChangePrice.Columns["storage_quantity"].HeaderText = "Stanje skladišta";

            dataGridViewChangePrice.CellFormatting += (s, e) =>
            {
                if (dataGridViewChangePrice.Columns[e.ColumnIndex].Name == "category")
                {
                    ItemCategory itemCategory;
                    if (Enum.TryParse((string)e.Value, out itemCategory))
                    {
                        e.Value = ItemCategoryUtility.itemCategoryTranslations[itemCategory];
                        e.FormattingApplied = true;
                    }
                }
            };

            dataGridViewChangePrice.ResumeLayout();

            veza.Close();
        }

        private void btnPotvrdiCijenu_Click(object sender, EventArgs e)
        {
            //provjerimo je li oznacen redak
            if (dataGridViewChangePrice.CurrentRow == null || dataGridViewChangePrice.CurrentRow.Index == -1)
            {
                MessageBox.Show("Molimo odaberite valjani redak za artikl kojem želite promijeniti cijenu!",
                                "Odaberite redak za odgovarajući artikl",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                return;
            }

            var val = this.dataGridViewChangePrice.SelectedRows[0].Cells[0].Value.ToString();
            if (val == null || val.Length == 0) return;

            int artiklId= int.Parse(val); //dohvaćam Id

            //provjerimo izraz u text boxu -> textBoxPromjenaCijene
            if(textBoxPromjenaCijene.Text.Length == 0)
            {
                MessageBox.Show("Niste upisali željenu cijenu!");
                return;
            }

            //provjera je li unesena cijena u odgovarajućem obliku xxxx,xx
            string unos = textBoxPromjenaCijene.Text.Trim();
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

                //Sve je ok!
                //Možemo ažurirati cijenu artikla
                updateCijenaArtikla(artiklId, cijena);
                ReadArtikl();
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

        private void btnUkloniOdabranog_Click(object sender, EventArgs e)
        {
            if (dataGridViewChangePrice.CurrentRow == null || dataGridViewChangePrice.CurrentRow.Index == -1)
            {
                MessageBox.Show("Molimo odaberite valjani redak za brisanje.",
                                "Greška",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            var val = this.dataGridViewChangePrice.SelectedRows[0].Cells[0].Value.ToString();
            if (val == null || val.Length == 0) return;

            int artiklDeleteId = int.Parse(val); //dohvaćam Id

            DialogResult dialogResult =
                CustomMessageBox.Show("Želite li sigurno maknuti artikl iz ponude?", "Brisanje artikla");

            if (dialogResult == DialogResult.Yes)
            {
                //dialogResult == DialogResult.Yes -> mičemo artikl s Tablice Artikl
                deleteArtiklFromCaffe(artiklDeleteId);

                ReadArtikl();
            }
        }

        /// <summary>
        /// Metoda koja briše artikl iz baze podataka koji je prethodno označen u data grid view
        /// </summary>
        /// <param name="artiklDeleteId">Odgovarajući id artikla koji označava artikl koji se mora ukloniti</param>
        private void deleteArtiklFromCaffe(int artiklDeleteId)
        {
            try
            {
                using (SqlConnection veza = new SqlConnection(connectionString))
                {
                    veza.Open();
                    string upit = "DELETE FROM Artikl WHERE Id=@Id";
                    using (SqlCommand command = new SqlCommand(upit, veza))
                    {
                        
                        command.Parameters.AddWithValue("@Id", artiklDeleteId);
                        command.ExecuteNonQuery();
                        
                    }
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.ToString()); }
        }
        
        /// <summary>
        /// Metoda koja ažurira cijenu artikla u bazi podataka
        /// </summary>
        /// <param name="id">Id artikla kojeg treba ažurirati</param>
        /// <param name="cijena">Nova cijena artikla nakon ažuriranja</param>
        private void updateCijenaArtikla(int id, decimal cijena)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "UPDATE Artikl " +
                        "SET price=@price " +
                        "WHERE Id=@Id";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@price", cijena);
                        command.Parameters.AddWithValue("@Id", id);
                        command.ExecuteNonQuery();

                        MessageBox.Show("Uspješno je ažurirana cijena artikla.",
                        "Uspješno ažuriranje",
                        MessageBoxButtons.OK);
                    }
                }
            }
            catch (Exception ex) { Console.WriteLine("Exception: " + ex.ToString()); }
        }
    }
}
