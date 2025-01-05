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
    /// <summary>
    /// Forma koja prestavlja prilagođeni MessageBox na koji se može odgovoriti s da/ne.
    /// </summary>
    public partial class CustomMessageBox : Form
    {
        public CustomMessageBox()
        {
            InitializeComponent();
        }

        public static DialogResult Show(string message, string title)
        {
            using (var dialog = new CustomMessageBox())
            {
                dialog.Text = title;
                dialog.lblMessage.Text = message;
                return dialog.ShowDialog();
            }
        }

        private void yesBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Yes;
            this.Close();
        }

        private void noBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
            this.Close();
        }
    }
}
