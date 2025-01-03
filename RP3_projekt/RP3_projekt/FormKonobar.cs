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

        public FormKonobar(Employee currentEmployee)
        {
            InitializeComponent();

            timer = new Timer();
            timer.Interval = 60 * 1000;
            timer.Tick += Timer_Tick;
            timer.Start();

            this.currentEmployee = currentEmployee;

            NotificationsService.Initialize(notificationsBtn);

            BillsControl control = new BillsControl(currentEmployee);
            ShowControl(control);
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
            ShowControl(control);
        }

        private void freezerBtn_Click(object sender, EventArgs e)
        {
            FreezerControl control = new FreezerControl();
            ShowControl(control);
        }

        private void storageBtn_Click(object sender, EventArgs e)
        {
            StorageControl control = new StorageControl();
            ShowControl(control);
        }

        private void shiftEndBtn_Click(object sender, EventArgs e)
        {
            ShiftEndControl control = new ShiftEndControl(currentEmployee, this);
            ShowControl(control);
        }

        private void notificationsBtn_Click(object sender, EventArgs e)
        {
            NotificationsControl control = new NotificationsControl();
            ShowControl(control);
        }

        private void ShowControl(UserControl control)
        {
            panelContent.Controls.Clear();
            control.Dock = DockStyle.Fill;
            panelContent.Controls.Add(control);
        }
    }
}
