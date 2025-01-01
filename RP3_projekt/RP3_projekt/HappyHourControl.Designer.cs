namespace RP3_projekt
{
    partial class HappyHourControl
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvSviArtikli = new System.Windows.Forms.DataGridView();
            this.dgvArtikliHH = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonDodaj = new System.Windows.Forms.Button();
            this.buttonMakni = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSviArtikli)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArtikliHH)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Prikaz svih artikala";
            // 
            // dgvSviArtikli
            // 
            this.dgvSviArtikli.AllowUserToAddRows = false;
            this.dgvSviArtikli.AllowUserToDeleteRows = false;
            this.dgvSviArtikli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSviArtikli.Location = new System.Drawing.Point(50, 69);
            this.dgvSviArtikli.MultiSelect = false;
            this.dgvSviArtikli.Name = "dgvSviArtikli";
            this.dgvSviArtikli.ReadOnly = true;
            this.dgvSviArtikli.RowHeadersWidth = 51;
            this.dgvSviArtikli.RowTemplate.Height = 24;
            this.dgvSviArtikli.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSviArtikli.Size = new System.Drawing.Size(571, 174);
            this.dgvSviArtikli.TabIndex = 1;
            // 
            // dgvArtikliHH
            // 
            this.dgvArtikliHH.AllowUserToAddRows = false;
            this.dgvArtikliHH.AllowUserToDeleteRows = false;
            this.dgvArtikliHH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArtikliHH.Location = new System.Drawing.Point(50, 302);
            this.dgvArtikliHH.MultiSelect = false;
            this.dgvArtikliHH.Name = "dgvArtikliHH";
            this.dgvArtikliHH.ReadOnly = true;
            this.dgvArtikliHH.RowHeadersWidth = 51;
            this.dgvArtikliHH.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArtikliHH.Size = new System.Drawing.Size(571, 165);
            this.dgvArtikliHH.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 272);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Trenutni artikli na happy hour-u";
            // 
            // buttonDodaj
            // 
            this.buttonDodaj.AutoSize = true;
            this.buttonDodaj.Location = new System.Drawing.Point(659, 217);
            this.buttonDodaj.Name = "buttonDodaj";
            this.buttonDodaj.Size = new System.Drawing.Size(75, 26);
            this.buttonDodaj.TabIndex = 4;
            this.buttonDodaj.Text = "Dodaj";
            this.buttonDodaj.UseVisualStyleBackColor = true;
            this.buttonDodaj.Click += new System.EventHandler(this.buttonDodaj_Click);
            // 
            // buttonMakni
            // 
            this.buttonMakni.Location = new System.Drawing.Point(659, 444);
            this.buttonMakni.Name = "buttonMakni";
            this.buttonMakni.Size = new System.Drawing.Size(75, 23);
            this.buttonMakni.TabIndex = 5;
            this.buttonMakni.Text = "Makni";
            this.buttonMakni.UseVisualStyleBackColor = true;
            this.buttonMakni.Click += new System.EventHandler(this.buttonMakni_Click);
            // 
            // HappyHourControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonMakni);
            this.Controls.Add(this.buttonDodaj);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvArtikliHH);
            this.Controls.Add(this.dgvSviArtikli);
            this.Controls.Add(this.label1);
            this.Name = "HappyHourControl";
            this.Size = new System.Drawing.Size(758, 514);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSviArtikli)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArtikliHH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvSviArtikli;
        private System.Windows.Forms.DataGridView dgvArtikliHH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonDodaj;
        private System.Windows.Forms.Button buttonMakni;
    }
}
