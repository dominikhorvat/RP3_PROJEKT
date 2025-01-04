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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace RP3_projekt
{
    public partial class FormKonobar : Form
    {
        private Employee currentEmployee;
        public Timer timer;
        private Button selectedButton;

        public FormKonobar(Employee currentEmployee)
        {
            InitializeComponent();

            timer = new Timer();
            timer.Interval = 60 * 1000;
            timer.Tick += Timer_Tick;
            timer.Start();

            this.currentEmployee = currentEmployee;

            NotificationsService.Initialize(notificationPictureBox);

            BillsControl control = new BillsControl(currentEmployee);
            ShowControl(control, billsBtn);
        }

        public void StopTimer()
        {
            timer.Stop();
            timer.Dispose();
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

        private void billsBtn_Click(object sender, EventArgs e)
        {
            BillsControl control = new BillsControl(currentEmployee);
            ShowControl(control, billsBtn);
        }

        private void freezerBtn_Click(object sender, EventArgs e)
        {
            FreezerControl control = new FreezerControl();
            ShowControl(control, freezerBtn);
        }

        private void storageBtn_Click(object sender, EventArgs e)
        {
            StorageControl control = new StorageControl();
            ShowControl(control, storageBtn);
        }

        private void shiftEndBtn_Click(object sender, EventArgs e)
        {
            ShiftEndControl control = new ShiftEndControl(currentEmployee, this);
            ShowControl(control, shiftEndBtn);
        }

        private void notificationPictureBox_Click(object sender, EventArgs e)
        {
            NotificationsControl control = new NotificationsControl();
            ShowControl(control, null);
        }

        private void ShowControl(UserControl control, Button button)
        {
            panelContent.Controls.Clear();
            control.Dock = DockStyle.Fill;
            panelContent.Controls.Add(control);

            if (button != null)
            {
                UpdateSelectedButton(button);
            }
        }

        private void UpdateSelectedButton(Button button)
        {
            if (selectedButton != null)
            {
                selectedButton.ForeColor = Color.White;
            }

            button.ForeColor = Color.Black;
            selectedButton = button;
        }
    }
}
