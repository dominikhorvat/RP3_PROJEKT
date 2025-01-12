namespace RP3_projekt
{
    partial class FormPrijava
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrijava));
            this.label1 = new System.Windows.Forms.Label();
            this.gumbPrijaviSe = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxUsernameLogin = new System.Windows.Forms.TextBox();
            this.textBoxPasswordLogin = new System.Windows.Forms.TextBox();
            this.checkBoxPrikaziLozinku = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Matura MT Script Capitals", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(143, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(464, 107);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dobrodošli";
            // 
            // gumbPrijaviSe
            // 
            this.gumbPrijaviSe.AutoSize = true;
            this.gumbPrijaviSe.BackColor = System.Drawing.Color.MistyRose;
            this.gumbPrijaviSe.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gumbPrijaviSe.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gumbPrijaviSe.ForeColor = System.Drawing.Color.Black;
            this.gumbPrijaviSe.Location = new System.Drawing.Point(557, 473);
            this.gumbPrijaviSe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gumbPrijaviSe.Name = "gumbPrijaviSe";
            this.gumbPrijaviSe.Size = new System.Drawing.Size(137, 41);
            this.gumbPrijaviSe.TabIndex = 1;
            this.gumbPrijaviSe.Text = "Prijavi se";
            this.gumbPrijaviSe.UseVisualStyleBackColor = false;
            this.gumbPrijaviSe.Click += new System.EventHandler(this.gumbPrijaviSe_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(320, 260);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "Korisničko ime:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(320, 359);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 30);
            this.label3.TabIndex = 3;
            this.label3.Text = "Lozinka:";
            // 
            // textBoxUsernameLogin
            // 
            this.textBoxUsernameLogin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUsernameLogin.Location = new System.Drawing.Point(325, 292);
            this.textBoxUsernameLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxUsernameLogin.Name = "textBoxUsernameLogin";
            this.textBoxUsernameLogin.Size = new System.Drawing.Size(333, 32);
            this.textBoxUsernameLogin.TabIndex = 4;
            // 
            // textBoxPasswordLogin
            // 
            this.textBoxPasswordLogin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPasswordLogin.Location = new System.Drawing.Point(325, 391);
            this.textBoxPasswordLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxPasswordLogin.Name = "textBoxPasswordLogin";
            this.textBoxPasswordLogin.Size = new System.Drawing.Size(333, 32);
            this.textBoxPasswordLogin.TabIndex = 5;
            this.textBoxPasswordLogin.UseSystemPasswordChar = true;
            // 
            // checkBoxPrikaziLozinku
            // 
            this.checkBoxPrikaziLozinku.AutoSize = true;
            this.checkBoxPrikaziLozinku.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxPrikaziLozinku.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBoxPrikaziLozinku.Location = new System.Drawing.Point(325, 429);
            this.checkBoxPrikaziLozinku.Name = "checkBoxPrikaziLozinku";
            this.checkBoxPrikaziLozinku.Size = new System.Drawing.Size(139, 24);
            this.checkBoxPrikaziLozinku.TabIndex = 6;
            this.checkBoxPrikaziLozinku.Text = "Prikaži lozinku";
            this.checkBoxPrikaziLozinku.UseVisualStyleBackColor = false;
            this.checkBoxPrikaziLozinku.CheckedChanged += new System.EventHandler(this.checkBoxPrikaziLozinku_CheckedChanged);
            // 
            // FormPrijava
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 703);
            this.Controls.Add(this.checkBoxPrikaziLozinku);
            this.Controls.Add(this.textBoxPasswordLogin);
            this.Controls.Add(this.textBoxUsernameLogin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gumbPrijaviSe);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "FormPrijava";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prijava";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Prijava_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button gumbPrijaviSe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxUsernameLogin;
        private System.Windows.Forms.TextBox textBoxPasswordLogin;
        private System.Windows.Forms.CheckBox checkBoxPrikaziLozinku;
    }
}