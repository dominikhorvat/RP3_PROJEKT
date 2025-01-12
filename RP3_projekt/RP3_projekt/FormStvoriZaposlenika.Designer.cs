namespace RP3_projekt
{
    partial class FormStvoriZaposlenika
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStvoriZaposlenika));
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.gumbStvoriZaposlenika = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxPasswordConfirm = new System.Windows.Forms.TextBox();
            this.checkBoxPrikaziLozinku = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUsername.Location = new System.Drawing.Point(224, 114);
            this.textBoxUsername.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxUsername.MaxLength = 49;
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(300, 27);
            this.textBoxUsername.TabIndex = 0;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassword.Location = new System.Drawing.Point(224, 165);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxPassword.MaxLength = 49;
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(300, 27);
            this.textBoxPassword.TabIndex = 1;
            this.textBoxPassword.UseSystemPasswordChar = true;
            // 
            // gumbStvoriZaposlenika
            // 
            this.gumbStvoriZaposlenika.AutoSize = true;
            this.gumbStvoriZaposlenika.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(175)))), ((int)(((byte)(175)))));
            this.gumbStvoriZaposlenika.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gumbStvoriZaposlenika.ForeColor = System.Drawing.Color.White;
            this.gumbStvoriZaposlenika.Location = new System.Drawing.Point(400, 286);
            this.gumbStvoriZaposlenika.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gumbStvoriZaposlenika.Name = "gumbStvoriZaposlenika";
            this.gumbStvoriZaposlenika.Size = new System.Drawing.Size(125, 54);
            this.gumbStvoriZaposlenika.TabIndex = 4;
            this.gumbStvoriZaposlenika.Text = "Potvrdi";
            this.gumbStvoriZaposlenika.UseVisualStyleBackColor = false;
            this.gumbStvoriZaposlenika.Click += new System.EventHandler(this.gumbStvoriZaposlenika_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Unesi korisničko ime:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Unesi lozinku:";
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(207)))), ((int)(((byte)(207)))));
            this.button1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(255, 286);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 54);
            this.button1.TabIndex = 3;
            this.button1.Text = "Otkaži";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "Potvrdi lozinku:";
            // 
            // textBoxPasswordConfirm
            // 
            this.textBoxPasswordConfirm.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPasswordConfirm.Location = new System.Drawing.Point(224, 212);
            this.textBoxPasswordConfirm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxPasswordConfirm.MaxLength = 49;
            this.textBoxPasswordConfirm.Name = "textBoxPasswordConfirm";
            this.textBoxPasswordConfirm.Size = new System.Drawing.Size(300, 27);
            this.textBoxPasswordConfirm.TabIndex = 2;
            this.textBoxPasswordConfirm.UseSystemPasswordChar = true;
            // 
            // checkBoxPrikaziLozinku
            // 
            this.checkBoxPrikaziLozinku.AutoSize = true;
            this.checkBoxPrikaziLozinku.Location = new System.Drawing.Point(224, 245);
            this.checkBoxPrikaziLozinku.Name = "checkBoxPrikaziLozinku";
            this.checkBoxPrikaziLozinku.Size = new System.Drawing.Size(113, 20);
            this.checkBoxPrikaziLozinku.TabIndex = 8;
            this.checkBoxPrikaziLozinku.Text = "Prikaži lozinku";
            this.checkBoxPrikaziLozinku.UseVisualStyleBackColor = true;
            this.checkBoxPrikaziLozinku.CheckedChanged += new System.EventHandler(this.checkBoxPrikaziLozinku_CheckedChanged);
            // 
            // FormStvoriZaposlenika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 425);
            this.Controls.Add(this.checkBoxPrikaziLozinku);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxPasswordConfirm);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gumbStvoriZaposlenika);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxUsername);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormStvoriZaposlenika";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Unos konobara";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Button gumbStvoriZaposlenika;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxPasswordConfirm;
        private System.Windows.Forms.CheckBox checkBoxPrikaziLozinku;
    }
}