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
    public partial class FormConsuption : Form
    {
        public FormConsuption()
        {
            InitializeComponent();
        }

        string connectionString = ConfigurationManager
           .ConnectionStrings["BazaCaffeBar"].ConnectionString;

        public void PopuniTablicuPotrosnje(DateTime pocetni, DateTime zavrsni)
        {
            try
            {
                string upit = @"
                SELECT 
                    a.Id AS Id, 
                    a.name AS Naziv, 
                    a.price AS Cijena, 
                    ISNULL(SUM(sr.quantity), 0) AS Prodano
                FROM 
                    Artikl a
                LEFT JOIN 
                    StavkaRacuna sr ON a.Id = sr.artikl_id
                LEFT JOIN 
                    Racun r ON sr.racun_id = r.Id
                WHERE 
                    CONVERT(DATE, r.time) BETWEEN CONVERT(DATE, @pocetni) AND CONVERT(DATE, @zavrsni)
                GROUP BY 
                    a.Id, a.name, a.price
                ORDER BY 
                    ISNULL(SUM(sr.quantity), 0) DESC";

                using (SqlConnection veza = new SqlConnection(connectionString))
                {
                    veza.Open();
                    using (SqlCommand command = new SqlCommand(upit, veza))
                    {
                        command.Parameters.AddWithValue("@pocetni", pocetni);
                        command.Parameters.AddWithValue("@zavrsni", zavrsni);

                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        if (table.Rows.Count == 0)
                        {
                            labelRazdobljePotrosnje.Text = "Za odabrano razdoblje nema niti jednog prodanog artikla.";
                            label2.Visible = false;
                        }
                        else
                        {
                            if(pocetni == zavrsni)
                            {
                                labelRazdobljePotrosnje.Text = $"Odabrali ste datum {pocetni.ToString("d.M.yyyy")}";
                            }
                            else
                            {
                                labelRazdobljePotrosnje.Text = $"Odabrano razdoblje od {pocetni.ToString("d.M.yyyy")} do {zavrsni.ToString("d.M.yyyy")}";
                            }
                            label2.Visible= true;
                            
                        }

                        dataGridViewPotrosnja.DataSource = table;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonZatvori_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
