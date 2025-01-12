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

namespace RP3_projekt
{
    public partial class FormStvoriZaposlenika : Form
    {
        public FormStvoriZaposlenika()
        {
            InitializeComponent();
        }

        string connectionString = ConfigurationManager
            .ConnectionStrings["BazaCaffeBar"].ConnectionString;

        private void gumbStvoriZaposlenika_Click(object sender, EventArgs e)
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

            string unos = textBoxUsername.Text;  
            string provjera = "^[a-zA-Z]+$";
            //Provjera sastoji li se korisničko ime samo od slova
            if (!Regex.IsMatch(unos, provjera))
            {
                MessageBox.Show("Korisničko ime mora sadržavati samo slova!");
                return;
            }

            if(textBoxPassword.Text != textBoxPasswordConfirm.Text)
            {
                MessageBox.Show("Unesene lozinke se ne podudaraju!");
                return;
            }

            string zaposlenik_username = textBoxUsername.Text;
            string zaposlenik_password = Hash(textBoxPassword.Text.ToString()); 

            SqlConnection veza = new SqlConnection(connectionString);
            veza.Open();

            //provjera postoji li već upisano korisničko ime u tablici
            //bolja opcija od UNIQUE ograničenja jer ovo neće povećati id u slučaju da korisničko ime postoji!
            string provjeraUpit = "SELECT COUNT(*) FROM [Zaposlenik] WHERE username = @username";
            SqlCommand provjeraNaredba = new SqlCommand(provjeraUpit, veza);

            provjeraNaredba.Parameters.AddWithValue("@username", zaposlenik_username);
            int brojPostojecih = (int)provjeraNaredba.ExecuteScalar();

            if (brojPostojecih > 0)
            {
                MessageBox.Show("Korisničko ime već postoji, probajte ponovo!");
                return;
            }

            string upit = "INSERT INTO [Zaposlenik]"
                + "(username,hash_password) " +
                "VALUES(@username, @hash_password)";
            SqlCommand naredba = new SqlCommand(upit, veza);
            naredba.Parameters.AddWithValue
                ("@username", zaposlenik_username);
            naredba.Parameters.AddWithValue
                ("@hash_password",zaposlenik_password);

            int brNovihRedaka = 0;

            //provjera da nismo ubacili nešto što ne odgovara specifikaciji tablice
            try
            {
                brNovihRedaka = naredba.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            MessageBox.Show("Broj dodanih zaposlenika: " + brNovihRedaka);

            veza.Close();

            this.DialogResult = DialogResult.OK;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        /// <summary>
        /// Metoda koja hashira lozinku
        /// </summary>
        /// <param name="password">Lozinka koja se šalje metodi kako bi se hashirala</param>
        /// <returns>vraća hash lozinke</returns>
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

        private void checkBoxPrikaziLozinku_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPrikaziLozinku.Checked)
            {
                textBoxPassword.UseSystemPasswordChar = false;
                textBoxPasswordConfirm.UseSystemPasswordChar = false;
            }
            else
            {
                textBoxPassword.UseSystemPasswordChar = true;
                textBoxPasswordConfirm.UseSystemPasswordChar = true;
            }
        }
    }
}
