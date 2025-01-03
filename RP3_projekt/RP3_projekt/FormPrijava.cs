using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace RP3_projekt
{
    public partial class FormPrijava : Form
    {
        public FormPrijava()
        {
            InitializeComponent();

            sirina = ClientSize.Width;
            visina = ClientSize.Height;
        }

        //za vezu s bazom 
        string connectionString = ConfigurationManager
            .ConnectionStrings["BazaCaffeBar"].ConnectionString;

        //za sliku u pozadini
        float sirina, visina;

        private void gumbPrijaviSe_Click(object sender, EventArgs e)
        {
            //pogledamo TextBoxeve i jesu li ispunjeni
            foreach (Control control in Controls)
            {
                if (control is TextBox t && t.Text.Length == 0)
                {
                    MessageBox.Show("Nisu popunjena sva polja!");
                    return;
                }
            }

            string username = textBoxUsernameLogin.Text;
            string password = textBoxPasswordLogin.Text;

            using (SqlConnection veza = new SqlConnection(connectionString))
            {
                veza.Open();

                //Ako su ispunjena oba polja projverimo ispravnost unosa u TextBoxeve
                string upit = "SELECT * FROM Zaposlenik " +
                            "WHERE username = @username AND hash_password = @hash_password";

                using (SqlCommand naredba = new SqlCommand(upit, veza))
                {
                    naredba.Parameters.AddWithValue("@username", username);
                    naredba.Parameters.AddWithValue("@hash_password", Hash(password));
                    
                    //dvije vrijednosti [authorization] i [last_login] -> onda radimo s .ExecuteReader()
                    SqlDataReader reader = naredba.ExecuteReader();

                    if (reader.Read()) //reader.Read() == true ako postoji zaposlenik
                    {
                        Employee employee = new Employee()
                        {
                            Id = (int)reader["id"],
                            Username = (string)reader["username"],
                            Authorization = (string)reader["authorization"],
                            Coffee = (byte)reader["coffee"],
                            Juice = (byte)reader["juice"],
                            LastLogin = (DateTime)reader["last_login"]
                        };
                        
                        /* 
                         * Trebamo provjeriti datum. Ako je dan različit od današnjeg prilikom prijave
                         * onda ažuriramo coffee na 2 i juice na 1, 
                         * ako je dan isti kao i prilikom prijave ne radimo ništa 
                         */

                        reader.Close(); //obavezno zatvoriti jer ne možemo unutar iste veze izvršiti više upita

                        //if (employee.LastLogin.Date != DateTime.Today)
                        //{
                        //    string updateUpit = "UPDATE Zaposlenik SET " +
                        //                        "coffee = 2, juice = 1 WHERE " +
                        //                        "username = @username";
                        //    using (SqlCommand updateNaredba = new SqlCommand(updateUpit, veza)) //zbog DataReadera
                        //    {
                        //        updateNaredba.Parameters.AddWithValue("@username", username);
                        //        updateNaredba.ExecuteNonQuery();
                        //    }
                        //}

                        ////trebamo ažurirat last_login na današnji datum i vrijeme
                        //string updateLastLoginUpit = "UPDATE Zaposlenik SET " +
                        //                            "last_login = @trenutnoVrijeme WHERE " +
                        //                            "username = @username";
                        //using (SqlCommand updateNaredba = new SqlCommand(updateLastLoginUpit, veza))
                        //{
                        //    updateNaredba.Parameters.AddWithValue("@trenutnoVrijeme", DateTime.Now);
                        //    updateNaredba.Parameters.AddWithValue("@username", username);
                        //    updateNaredba.ExecuteNonQuery();
                        //}

                        if (employee.Authorization == "Konobar")
                        {
                            FormKonobar formaKonobar = new FormKonobar(employee);
                            //Hide(); //sakrivamo formu za login kad je pokrenuta nova forma
                            Visible = false;
                            formaKonobar.ShowDialog();
                            Visible = true;
                            //Close();
                        }
                        else //ovlast je "Vlasnik"
                        {
                            FormVlasnik formaVlasnik = new FormVlasnik();
                            //Hide(); //sakrivamo formu za login kad je pokrenuta nova forma
                            Visible = false;
                            formaVlasnik.ShowDialog();
                            Visible = true;
                            //Close(); 
                        }
                    }
                    else
                    {
                        MessageBox.Show("Provjerite ispravnost unesenih podataka!", "Netočni podaci za prijavu");
                    }
                }
            }
        }

        private string Hash(string password)
        {
            var bytes = new UTF8Encoding().GetBytes(password);
            byte[] hashBytes;
            using (var algorithm = new System.Security.Cryptography.SHA512Managed())
            {
                hashBytes = algorithm.ComputeHash(bytes);
            }
            return Convert.ToBase64String(hashBytes);
        }

        //Događaj za crtanje pozadine
        private void Prijava_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(Properties.Resources.loginbg, 0, 0, sirina, visina);
        }
    }
}
