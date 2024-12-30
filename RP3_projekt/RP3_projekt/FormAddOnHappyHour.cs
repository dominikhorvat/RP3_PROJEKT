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
    public partial class FormAddOnHappyHour : Form
    {
        public int IdArtikla { get; set; }

        public FormAddOnHappyHour()
        {
            InitializeComponent();

            //postavimo oblik za vrijeme i datum
            dateTimePickerFrom.Format = DateTimePickerFormat.Custom;
            dateTimePickerFrom.CustomFormat = "dd.MM.yyyy HH:mm";
            dateTimePickerFrom.MinDate = DateTime.Now; //trenutno vrijeme kao minimalno

            dateTimePickerUntil.Format = DateTimePickerFormat.Custom;
            dateTimePickerUntil.CustomFormat = "dd.MM.yyyy HH:mm";
            dateTimePickerUntil.MinDate = DateTime.Now; 
        }

        string connectionString = ConfigurationManager
        .ConnectionStrings["BazaCaffeBar"].ConnectionString;

        public void FillInfoArtikl(decimal price, string name, int freezerQuantity, int storageQuantity)
        {
            this.labelName.Text = name;
            this.labelPrice.Text = "" + price;
            this.labelFreezer.Text = "" + freezerQuantity;
            this.labelStorage.Text = "" + storageQuantity;
        }

        private void buttonPotvrdi_Click(object sender, EventArgs e)
        {
            //vrijednost za popust
            decimal discount = numericUpDownDiscount.Value;

            //trebam datume!
            DateTime timeFrom = dateTimePickerFrom.Value;
            DateTime timeUntil = dateTimePickerUntil.Value;

            //provjera jesu li timeFrom i timeUntil različiti
            //i timeFrom < timeUntil barem 6 sati razlike

            if (timeFrom >= timeUntil)
            {
                MessageBox.Show("Vrijeme početka mora biti manje od vremena završetka!");
                return;
            }

            TimeSpan razlika = timeUntil.Subtract(timeFrom);
            if (razlika.TotalHours < 6)
            {
                MessageBox.Show("Razmak između početka i završetka mora biti najmanje 6 sati!");
                return;
            }

            //dodajemo dalje...
            SqlConnection veza = new SqlConnection(connectionString);
            veza.Open();

            string upit = "INSERT INTO [HappyHour]"
                + "(artikl_id,discount,time_from,time_until) " +
                "VALUES(@artikl_id, @discount, @time_from, @time_until)";
            SqlCommand naredba = new SqlCommand(upit, veza);
            naredba.Parameters.AddWithValue
                ("@artikl_id", IdArtikla);
            naredba.Parameters.AddWithValue
                ("@discount", discount);
            naredba.Parameters.AddWithValue
                ("@time_from", timeFrom);
            naredba.Parameters.AddWithValue
                ("@time_until", timeUntil);

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

            if (brNovihRedaka > 0)
            {
                MessageBox.Show("Uspješno ste dodali artikl na happy hour!");
            }

            veza.Close();

            this.DialogResult = DialogResult.OK;
        }

        private void buttonOtkazi_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
