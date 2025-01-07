
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
    public partial class FormAllTimeConsuption : Form
    {
        public FormAllTimeConsuption()
        {
            InitializeComponent();
        }

        string connectionString = ConfigurationManager
           .ConnectionStrings["BazaCaffeBar"].ConnectionString;


        public void PopuniTablicuSvePotrosnje()
        {
            using (SqlConnection veza = new SqlConnection(connectionString))
            {
                string upit = @"
                SELECT 
                    a.name AS Artikl,
                    COALESCE(SUM(SR.quantity), 0) AS Ukupna
                FROM 
                    Artikl a
                LEFT JOIN StavkaRacuna sr ON a.Id = sr.artikl_id
                LEFT JOIN Racun r ON sr.racun_id = r.Id
                GROUP BY 
                    a.name
                ORDER BY 
                    Ukupna DESC";

                SqlDataAdapter da = new SqlDataAdapter(upit, veza);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewSvaPotrosnja.DataSource = dt;
            }
        }

        private void buttonZatvori_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
