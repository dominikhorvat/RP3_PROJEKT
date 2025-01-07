namespace RP3_projekt
{
    partial class FormAllTimeConsuption
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAllTimeConsuption));
            this.dataGridViewSvaPotrosnja = new System.Windows.Forms.DataGridView();
            this.buttonZatvori = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSvaPotrosnja)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewSvaPotrosnja
            // 
            this.dataGridViewSvaPotrosnja.AllowUserToAddRows = false;
            this.dataGridViewSvaPotrosnja.AllowUserToDeleteRows = false;
            this.dataGridViewSvaPotrosnja.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSvaPotrosnja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSvaPotrosnja.Location = new System.Drawing.Point(34, 50);
            this.dataGridViewSvaPotrosnja.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewSvaPotrosnja.Name = "dataGridViewSvaPotrosnja";
            this.dataGridViewSvaPotrosnja.ReadOnly = true;
            this.dataGridViewSvaPotrosnja.RowHeadersWidth = 51;
            this.dataGridViewSvaPotrosnja.RowTemplate.Height = 24;
            this.dataGridViewSvaPotrosnja.Size = new System.Drawing.Size(582, 313);
            this.dataGridViewSvaPotrosnja.TabIndex = 0;
            // 
            // buttonZatvori
            // 
            this.buttonZatvori.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(175)))), ((int)(((byte)(175)))));
            this.buttonZatvori.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonZatvori.ForeColor = System.Drawing.Color.White;
            this.buttonZatvori.Location = new System.Drawing.Point(275, 378);
            this.buttonZatvori.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonZatvori.Name = "buttonZatvori";
            this.buttonZatvori.Size = new System.Drawing.Size(93, 38);
            this.buttonZatvori.TabIndex = 1;
            this.buttonZatvori.Text = "Zatvori";
            this.buttonZatvori.UseVisualStyleBackColor = false;
            this.buttonZatvori.Click += new System.EventHandler(this.buttonZatvori_Click);
            // 
            // FormAllTimeConsuption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 437);
            this.Controls.Add(this.buttonZatvori);
            this.Controls.Add(this.dataGridViewSvaPotrosnja);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "FormAllTimeConsuption";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cjelokupna potrošnja";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSvaPotrosnja)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewSvaPotrosnja;
        private System.Windows.Forms.Button buttonZatvori;
    }
}