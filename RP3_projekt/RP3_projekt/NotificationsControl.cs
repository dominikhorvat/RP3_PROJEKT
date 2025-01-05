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
    public partial class NotificationsControl : UserControl
    {
        public NotificationsControl()
        {
            InitializeComponent();

            DisplayNotifications();
        }

        #region Prikaz postojećih notifikacija
        private void DisplayNotifications()
        {
            List<Notification> notifications = NotificationsService.GetAllNotifications();

            foreach (Notification notification in notifications) {
                notificationsView.Items.Add(notification);
            }
        }
        #endregion
    }
}
