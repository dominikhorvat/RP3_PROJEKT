namespace RP3_projekt
{
    partial class FormVlasnik
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
            this.panelSidebar = new System.Windows.Forms.Panel();
            this.pictureBoxLogoutIcon = new System.Windows.Forms.PictureBox();
            this.btnDodajNoviArtikl = new System.Windows.Forms.Button();
            this.pictureBoxInfoIcon = new System.Windows.Forms.PictureBox();
            this.btnUpravljajArtiklima = new System.Windows.Forms.Button();
            this.btnPotrosnja = new System.Windows.Forms.Button();
            this.btnHappyHour = new System.Windows.Forms.Button();
            this.btnZaposlenici = new System.Windows.Forms.Button();
            this.panelContent = new System.Windows.Forms.Panel();
            this.panelSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogoutIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInfoIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSidebar
            // 
            this.panelSidebar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panelSidebar.Controls.Add(this.pictureBoxLogoutIcon);
            this.panelSidebar.Controls.Add(this.btnDodajNoviArtikl);
            this.panelSidebar.Controls.Add(this.pictureBoxInfoIcon);
            this.panelSidebar.Controls.Add(this.btnUpravljajArtiklima);
            this.panelSidebar.Controls.Add(this.btnPotrosnja);
            this.panelSidebar.Controls.Add(this.btnHappyHour);
            this.panelSidebar.Controls.Add(this.btnZaposlenici);
            this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSidebar.Location = new System.Drawing.Point(0, 0);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Size = new System.Drawing.Size(259, 803);
            this.panelSidebar.TabIndex = 0;
            // 
            // pictureBoxLogoutIcon
            // 
            this.pictureBoxLogoutIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBoxLogoutIcon.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxLogoutIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxLogoutIcon.Image = global::RP3_projekt.Properties.Resources.logouticon;
            this.pictureBoxLogoutIcon.Location = new System.Drawing.Point(204, 742);
            this.pictureBoxLogoutIcon.Name = "pictureBoxLogoutIcon";
            this.pictureBoxLogoutIcon.Size = new System.Drawing.Size(49, 49);
            this.pictureBoxLogoutIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogoutIcon.TabIndex = 6;
            this.pictureBoxLogoutIcon.TabStop = false;
            this.pictureBoxLogoutIcon.Click += new System.EventHandler(this.pictureBoxLogoutIcon_Click);
            // 
            // btnDodajNoviArtikl
            // 
            this.btnDodajNoviArtikl.Location = new System.Drawing.Point(55, 197);
            this.btnDodajNoviArtikl.Name = "btnDodajNoviArtikl";
            this.btnDodajNoviArtikl.Size = new System.Drawing.Size(136, 46);
            this.btnDodajNoviArtikl.TabIndex = 5;
            this.btnDodajNoviArtikl.Text = "Dodaj novi artikl";
            this.btnDodajNoviArtikl.UseVisualStyleBackColor = true;
            this.btnDodajNoviArtikl.Click += new System.EventHandler(this.btnDodajNoviArtikl_Click);
            // 
            // pictureBoxInfoIcon
            // 
            this.pictureBoxInfoIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBoxInfoIcon.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxInfoIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxInfoIcon.Image = global::RP3_projekt.Properties.Resources.infoicon;
            this.pictureBoxInfoIcon.Location = new System.Drawing.Point(12, 742);
            this.pictureBoxInfoIcon.Name = "pictureBoxInfoIcon";
            this.pictureBoxInfoIcon.Size = new System.Drawing.Size(49, 49);
            this.pictureBoxInfoIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxInfoIcon.TabIndex = 4;
            this.pictureBoxInfoIcon.TabStop = false;
            this.pictureBoxInfoIcon.Click += new System.EventHandler(this.pictureBoxInfoIcon_Click);
            // 
            // btnUpravljajArtiklima
            // 
            this.btnUpravljajArtiklima.Location = new System.Drawing.Point(55, 91);
            this.btnUpravljajArtiklima.Name = "btnUpravljajArtiklima";
            this.btnUpravljajArtiklima.Size = new System.Drawing.Size(136, 45);
            this.btnUpravljajArtiklima.TabIndex = 3;
            this.btnUpravljajArtiklima.Text = "Upravljaj artiklima";
            this.btnUpravljajArtiklima.UseVisualStyleBackColor = true;
            this.btnUpravljajArtiklima.Click += new System.EventHandler(this.btnUpravljajArtiklima_Click);
            // 
            // btnPotrosnja
            // 
            this.btnPotrosnja.Location = new System.Drawing.Point(55, 529);
            this.btnPotrosnja.Name = "btnPotrosnja";
            this.btnPotrosnja.Size = new System.Drawing.Size(136, 44);
            this.btnPotrosnja.TabIndex = 2;
            this.btnPotrosnja.Text = "Potrošnja";
            this.btnPotrosnja.UseVisualStyleBackColor = true;
            this.btnPotrosnja.Click += new System.EventHandler(this.btnPotrosnja_Click);
            // 
            // btnHappyHour
            // 
            this.btnHappyHour.Location = new System.Drawing.Point(55, 423);
            this.btnHappyHour.Name = "btnHappyHour";
            this.btnHappyHour.Size = new System.Drawing.Size(136, 44);
            this.btnHappyHour.TabIndex = 1;
            this.btnHappyHour.Text = "Happy Hour";
            this.btnHappyHour.UseVisualStyleBackColor = true;
            this.btnHappyHour.Click += new System.EventHandler(this.btnHappyHour_Click);
            // 
            // btnZaposlenici
            // 
            this.btnZaposlenici.Location = new System.Drawing.Point(55, 305);
            this.btnZaposlenici.Name = "btnZaposlenici";
            this.btnZaposlenici.Size = new System.Drawing.Size(136, 46);
            this.btnZaposlenici.TabIndex = 0;
            this.btnZaposlenici.Text = "Zaposlenici";
            this.btnZaposlenici.UseVisualStyleBackColor = true;
            this.btnZaposlenici.Click += new System.EventHandler(this.btnZaposlenici_Click);
            // 
            // panelContent
            // 
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(259, 0);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(898, 803);
            this.panelContent.TabIndex = 1;
            // 
            // FormVlasnik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1157, 803);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelSidebar);
            this.Name = "FormVlasnik";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Forma za vlasnika";
            this.panelSidebar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogoutIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInfoIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Button btnHappyHour;
        private System.Windows.Forms.Button btnZaposlenici;
        private System.Windows.Forms.Button btnPotrosnja;
        private System.Windows.Forms.Button btnUpravljajArtiklima;
        private System.Windows.Forms.PictureBox pictureBoxInfoIcon;
        private System.Windows.Forms.Button btnDodajNoviArtikl;
        private System.Windows.Forms.PictureBox pictureBoxLogoutIcon;
    }
}