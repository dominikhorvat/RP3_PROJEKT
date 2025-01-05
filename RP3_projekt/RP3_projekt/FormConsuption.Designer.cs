namespace RP3_projekt
{
    partial class FormConsuption
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
            this.labelRazdobljePotrosnje = new System.Windows.Forms.Label();
            this.dataGridViewPotrosnja = new System.Windows.Forms.DataGridView();
            this.buttonZatvori = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPotrosnja)).BeginInit();
            this.SuspendLayout();
            // 
            // labelRazdobljePotrosnje
            // 
            this.labelRazdobljePotrosnje.AutoSize = true;
            this.labelRazdobljePotrosnje.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelRazdobljePotrosnje.Location = new System.Drawing.Point(12, 47);
            this.labelRazdobljePotrosnje.Name = "labelRazdobljePotrosnje";
            this.labelRazdobljePotrosnje.Size = new System.Drawing.Size(0, 20);
            this.labelRazdobljePotrosnje.TabIndex = 0;
            // 
            // dataGridViewPotrosnja
            // 
            this.dataGridViewPotrosnja.AllowUserToAddRows = false;
            this.dataGridViewPotrosnja.AllowUserToDeleteRows = false;
            this.dataGridViewPotrosnja.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPotrosnja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPotrosnja.Location = new System.Drawing.Point(15, 95);
            this.dataGridViewPotrosnja.Name = "dataGridViewPotrosnja";
            this.dataGridViewPotrosnja.ReadOnly = true;
            this.dataGridViewPotrosnja.RowHeadersWidth = 51;
            this.dataGridViewPotrosnja.RowTemplate.Height = 24;
            this.dataGridViewPotrosnja.Size = new System.Drawing.Size(880, 332);
            this.dataGridViewPotrosnja.TabIndex = 1;
            // 
            // buttonZatvori
            // 
            this.buttonZatvori.AutoSize = true;
            this.buttonZatvori.Location = new System.Drawing.Point(408, 490);
            this.buttonZatvori.Name = "buttonZatvori";
            this.buttonZatvori.Size = new System.Drawing.Size(58, 26);
            this.buttonZatvori.TabIndex = 2;
            this.buttonZatvori.Text = "Zatvori";
            this.buttonZatvori.UseVisualStyleBackColor = true;
            this.buttonZatvori.Click += new System.EventHandler(this.buttonZatvori_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label2.Location = new System.Drawing.Point(377, 430);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(505, 19);
            this.label2.TabIndex = 9;
            this.label2.Text = "Artikli koji se ne prikazuju na popisu nisu prodani u odabranom razdoblju";
            // 
            // FormConsuption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 546);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonZatvori);
            this.Controls.Add(this.dataGridViewPotrosnja);
            this.Controls.Add(this.labelRazdobljePotrosnje);
            this.Name = "FormConsuption";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Potrošnja artikla";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPotrosnja)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelRazdobljePotrosnje;
        private System.Windows.Forms.DataGridView dataGridViewPotrosnja;
        private System.Windows.Forms.Button buttonZatvori;
        private System.Windows.Forms.Label label2;
    }
}