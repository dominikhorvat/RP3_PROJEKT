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
    public partial class FormVlasnik : Form
    {
        private Timer timer;
        public FormVlasnik()
        {
            InitializeComponent();

            timer = new Timer();
            timer.Interval = 60 * 1000;
            timer.Tick += Timer_Tick; 
            timer.Start();

            ManagementControl managementCon = new ManagementControl();
            ShowControl(managementCon);
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            moveFromHappyHour();
        }

        private void moveFromHappyHour()
        {
            string connectionString = ConfigurationManager
           .ConnectionStrings["BazaCaffeBar"].ConnectionString;

            try
            {
                using (SqlConnection veza = new SqlConnection(connectionString))
                {
                    veza.Open();
                    string upit = "DELETE FROM HappyHour WHERE GETDATE() > time_until";
                    using (SqlCommand command = new SqlCommand(upit, veza))
                    {
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.ToString()); }
        }

        private void btnZaposlenici_Click(object sender, EventArgs e)
        {
            EmployeeControl employeeCon = new EmployeeControl();
            ShowControl(employeeCon);
        }

        private void btnHappyHour_Click(object sender, EventArgs e)
        {
            HappyHourControl happyhourCon = new HappyHourControl();
            ShowControl(happyhourCon);
        }

        private void btnUpravljajArtiklima_Click(object sender, EventArgs e)
        {
            ManagementControl managementCon = new ManagementControl();
            ShowControl(managementCon);
        }

        private void btnPotrosnja_Click(object sender, EventArgs e)
        {
            ConsuptionControl consuptionControl = new ConsuptionControl();
            ShowControl(consuptionControl); 
        }

        private void btnDodajNoviArtikl_Click(object sender, EventArgs e)
        {
            AddNewArtiklControl addNewArtiklControl = new AddNewArtiklControl();
            ShowControl(addNewArtiklControl);
        }

        private void ShowControl(UserControl control)
        {
            panelContent.Controls.Clear();
            control.Dock = DockStyle.Fill;
            panelContent.Controls.Add(control);
        }

        private void pictureBoxInfoIcon_Click(object sender, EventArgs e)
        {
            VlasnikInfoControl vlasnikInfoCon = new VlasnikInfoControl();
            ShowControl(vlasnikInfoCon);
        }

        private void pictureBoxLogoutIcon_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Želite li se odjaviti iz aplikacije?",
                                   "Odjava",
                                   MessageBoxButtons.YesNo,
                                   MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                //zaustavimo prvo timer, iako ne treba jer se odnosi samo na ovu formu, nije na odmet
                timer.Stop();
                timer.Dispose();

                Close();
            }
        }
    }
}
