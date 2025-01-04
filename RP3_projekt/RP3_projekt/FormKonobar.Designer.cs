namespace RP3_projekt
{
    partial class FormKonobar
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormKonobar));
            this.panelSidebar = new System.Windows.Forms.Panel();
            this.shiftEndBtn = new System.Windows.Forms.Button();
            this.storageBtn = new System.Windows.Forms.Button();
            this.freezerBtn = new System.Windows.Forms.Button();
            this.billsBtn = new System.Windows.Forms.Button();
            this.panelContent = new System.Windows.Forms.Panel();
            this.notificationPictureBox = new System.Windows.Forms.PictureBox();
            this.panelSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.notificationPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSidebar
            // 
            this.panelSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(207)))), ((int)(((byte)(207)))));
            this.panelSidebar.Controls.Add(this.notificationPictureBox);
            this.panelSidebar.Controls.Add(this.shiftEndBtn);
            this.panelSidebar.Controls.Add(this.storageBtn);
            this.panelSidebar.Controls.Add(this.freezerBtn);
            this.panelSidebar.Controls.Add(this.billsBtn);
            this.panelSidebar.Location = new System.Drawing.Point(0, 0);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Size = new System.Drawing.Size(199, 652);
            this.panelSidebar.TabIndex = 0;
            // 
            // shiftEndBtn
            // 
            this.shiftEndBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(175)))), ((int)(((byte)(175)))));
            this.shiftEndBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.shiftEndBtn.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.shiftEndBtn.ForeColor = System.Drawing.Color.White;
            this.shiftEndBtn.Location = new System.Drawing.Point(0, 159);
            this.shiftEndBtn.Name = "shiftEndBtn";
            this.shiftEndBtn.Size = new System.Drawing.Size(199, 53);
            this.shiftEndBtn.TabIndex = 3;
            this.shiftEndBtn.Text = "Kraj smjene";
            this.shiftEndBtn.UseVisualStyleBackColor = false;
            this.shiftEndBtn.Click += new System.EventHandler(this.shiftEndBtn_Click);
            // 
            // storageBtn
            // 
            this.storageBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(175)))), ((int)(((byte)(175)))));
            this.storageBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.storageBtn.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.storageBtn.ForeColor = System.Drawing.Color.White;
            this.storageBtn.Location = new System.Drawing.Point(0, 106);
            this.storageBtn.Name = "storageBtn";
            this.storageBtn.Size = new System.Drawing.Size(199, 53);
            this.storageBtn.TabIndex = 2;
            this.storageBtn.Text = "Stanje skladišta";
            this.storageBtn.UseVisualStyleBackColor = false;
            this.storageBtn.Click += new System.EventHandler(this.storageBtn_Click);
            // 
            // freezerBtn
            // 
            this.freezerBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(175)))), ((int)(((byte)(175)))));
            this.freezerBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.freezerBtn.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.freezerBtn.ForeColor = System.Drawing.Color.White;
            this.freezerBtn.Location = new System.Drawing.Point(0, 53);
            this.freezerBtn.Name = "freezerBtn";
            this.freezerBtn.Size = new System.Drawing.Size(199, 53);
            this.freezerBtn.TabIndex = 1;
            this.freezerBtn.Text = "Stanje hladnjaka";
            this.freezerBtn.UseVisualStyleBackColor = false;
            this.freezerBtn.Click += new System.EventHandler(this.freezerBtn_Click);
            // 
            // billsBtn
            // 
            this.billsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(175)))), ((int)(((byte)(175)))));
            this.billsBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.billsBtn.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.billsBtn.ForeColor = System.Drawing.Color.White;
            this.billsBtn.Location = new System.Drawing.Point(0, 0);
            this.billsBtn.Name = "billsBtn";
            this.billsBtn.Size = new System.Drawing.Size(199, 53);
            this.billsBtn.TabIndex = 0;
            this.billsBtn.Text = "Izdavanje računa";
            this.billsBtn.UseVisualStyleBackColor = false;
            this.billsBtn.Click += new System.EventHandler(this.billsBtn_Click);
            // 
            // panelContent
            // 
            this.panelContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.panelContent.Location = new System.Drawing.Point(199, 0);
            this.panelContent.Margin = new System.Windows.Forms.Padding(2);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(669, 652);
            this.panelContent.TabIndex = 1;
            // 
            // notificationPictureBox
            // 
            this.notificationPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.notificationPictureBox.Image = global::RP3_projekt.Properties.Resources.notification;
            this.notificationPictureBox.Location = new System.Drawing.Point(12, 602);
            this.notificationPictureBox.Name = "notificationPictureBox";
            this.notificationPictureBox.Size = new System.Drawing.Size(42, 38);
            this.notificationPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.notificationPictureBox.TabIndex = 4;
            this.notificationPictureBox.TabStop = false;
            this.notificationPictureBox.Click += new System.EventHandler(this.notificationPictureBox_Click);
            // 
            // FormKonobar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 652);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelSidebar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "FormKonobar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Caffe bar - konobar";
            this.panelSidebar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.notificationPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.Button shiftEndBtn;
        private System.Windows.Forms.Button storageBtn;
        private System.Windows.Forms.Button freezerBtn;
        private System.Windows.Forms.Button billsBtn;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.PictureBox notificationPictureBox;
    }
}