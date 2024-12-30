using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RP3_projekt
{
    public partial class FormVlasnik : Form
    {
        public FormVlasnik()
        {
            InitializeComponent();
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

        private void ShowControl(UserControl control)
        {
            panelContent.Controls.Clear();
            control.Dock = DockStyle.Fill;
            panelContent.Controls.Add(control);
        }

        private void buttonInfoVlasnik_Click(object sender, EventArgs e)
        {

        }
    }
}
