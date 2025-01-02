namespace RP3_projekt
{
    partial class NotificationsControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.notificationsView = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // notificationsView
            // 
            this.notificationsView.FormattingEnabled = true;
            this.notificationsView.HorizontalScrollbar = true;
            this.notificationsView.Location = new System.Drawing.Point(34, 45);
            this.notificationsView.Name = "notificationsView";
            this.notificationsView.Size = new System.Drawing.Size(498, 420);
            this.notificationsView.TabIndex = 0;
            // 
            // NotificationsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.notificationsView);
            this.Name = "NotificationsControl";
            this.Size = new System.Drawing.Size(574, 594);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox notificationsView;
    }
}
