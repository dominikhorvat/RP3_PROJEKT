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
    public partial class EmployeeControl : UserControl
    {
        public EmployeeControl()
        {
            InitializeComponent();

            ReadAllEmployees();

            //pretplaćujemo se na događaj koji onemogućuje gumb za otkaz u slučaju da je odabran vlasnik
            dataGridViewEmployee.SelectionChanged += DataGridViewEmployee_SelectionChanged;
        }

        string connectionString = ConfigurationManager
            .ConnectionStrings["BazaCaffeBar"].ConnectionString;

        private void ReadAllEmployees()
        {
            SqlConnection veza = new SqlConnection(connectionString);

            veza.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Zaposlenik", veza);

            DataTable dt = new DataTable();

            adapter.Fill(dt);

            dataGridViewEmployee.DataSource = dt;

            veza.Close();
        }

        private void buttonZaposli_Click(object sender, EventArgs e)
        {
            FormStvoriZaposlenika formSZ = new FormStvoriZaposlenika();

            if (formSZ.ShowDialog() == DialogResult.OK)
            {
                ReadAllEmployees();
            }
        }

        private void buttonOtkaz_Click(object sender, EventArgs e)
        {
            //nepotrebna provjera s obzirom na properties data view grid-a, ali za svaki slucaj
            if (dataGridViewEmployee.CurrentRow == null || dataGridViewEmployee.CurrentRow.Index == -1)
            {
                MessageBox.Show("Molimo odaberite valjani redak za brisanje.", 
                                "Greška", 
                                MessageBoxButtons.OK, 
                                MessageBoxIcon.Warning);
                return;
            }

            var val = this.dataGridViewEmployee.SelectedRows[0].Cells[0].Value.ToString();
            if (val == null || val.Length == 0) return;

            int employeeId = int.Parse(val);

            DialogResult dialogResult =
                MessageBox.Show("Jeste li sigurni da želite dati otkaz odabranom konobaru?",
                                "Otkaz konobara",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question);

            if (dialogResult == DialogResult.No)
            {
                return;
            }

            deleteFromEmployee(employeeId);

            ReadAllEmployees();
        }

        private void deleteFromEmployee(int idEmployee)
        {
            try
            {
                using (SqlConnection veza = new SqlConnection(connectionString))
                {
                    veza.Open();
                    string upit = "DELETE FROM Zaposlenik WHERE id=@id";
                    using (SqlCommand command = new SqlCommand(upit, veza))
                    {
                        {
                            command.Parameters.AddWithValue("@id", idEmployee);
                            command.ExecuteNonQuery();
                        }
                    }
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.ToString()); }
        }

        private void DataGridViewEmployee_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewEmployee.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridViewEmployee.SelectedRows[0];
                string ovlast = selectedRow.Cells["authorization"].Value.ToString();

                if (ovlast == "Vlasnik")
                {
                    buttonOtkaz.Enabled = false;
                }
                else
                {
                    buttonOtkaz.Enabled = true;
                }
            }
            else
            {
                buttonOtkaz.Enabled = false;
            }
        }
    }
}
