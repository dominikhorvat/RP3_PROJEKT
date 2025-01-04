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
        private Button selectedButton = null;
        private Timer timer;
        public FormVlasnik()
        {
            InitializeComponent();

            timer = new Timer();
            timer.Interval = 60 * 1000;
            timer.Tick += Timer_Tick; 
            timer.Start();

            ManagementControl managementCon = new ManagementControl();
            ShowControl(managementCon, btnUpravljajArtiklima);
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
            ShowControl(employeeCon, btnZaposlenici);
        }

        private void btnHappyHour_Click(object sender, EventArgs e)
        {
            HappyHourControl happyhourCon = new HappyHourControl();
            ShowControl(happyhourCon, btnHappyHour);
        }

        private void btnUpravljajArtiklima_Click(object sender, EventArgs e)
        {
            ManagementControl managementCon = new ManagementControl();
            ShowControl(managementCon, btnUpravljajArtiklima);
        }

        private void btnPotrosnja_Click(object sender, EventArgs e)
        {
            ConsuptionControl consuptionControl = new ConsuptionControl();
            ShowControl(consuptionControl, btnPotrosnja); 
        }

        private void btnDodajNoviArtikl_Click(object sender, EventArgs e)
        {
            AddNewArtiklControl addNewArtiklControl = new AddNewArtiklControl();
            ShowControl(addNewArtiklControl, btnDodajNoviArtikl);
        }

        private void ShowControl(UserControl control, Button button)
        {
            panelContent.Controls.Clear();
            control.Dock = DockStyle.Fill;
            panelContent.Controls.Add(control);
            UpdateSelectedButton(button);
        }

        private void pictureBoxInfoIcon_Click(object sender, EventArgs e)
        {
            VlasnikInfoControl vlasnikInfoCon = new VlasnikInfoControl();
            ShowControl(vlasnikInfoCon, null);
        }

        private void pictureBoxLogoutIcon_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = CustomMessageBox.Show("Želite li se odjaviti iz aplikacije?",
                                   "Odjava");
            if (dialogResult == DialogResult.Yes)
            {
                //zaustavimo prvo timer, iako ne treba jer se odnosi samo na ovu formu, nije na odmet
                timer.Stop();
                timer.Dispose();

                Close();
            }
        }

        private void UpdateSelectedButton(Button button)
        {
            if (selectedButton != null)
            {
                selectedButton.ForeColor = Color.White;
            }
            if (button != null)
            {
                button.ForeColor = Color.Black;
            }
            selectedButton = button;
        }
    }
}
