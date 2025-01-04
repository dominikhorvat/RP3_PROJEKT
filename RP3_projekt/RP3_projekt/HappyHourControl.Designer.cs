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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSviArtikli)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArtikliHH)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(201, 344);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Odabir artikla za novi happy hour popust";
            // 
            // dgvSviArtikli
            // 
            this.dgvSviArtikli.AllowUserToAddRows = false;
            this.dgvSviArtikli.AllowUserToDeleteRows = false;
            this.dgvSviArtikli.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSviArtikli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSviArtikli.Location = new System.Drawing.Point(38, 373);
            this.dgvSviArtikli.Margin = new System.Windows.Forms.Padding(2);
            this.dgvSviArtikli.MultiSelect = false;
            this.dgvSviArtikli.Name = "dgvSviArtikli";
            this.dgvSviArtikli.ReadOnly = true;
            this.dgvSviArtikli.RowHeadersWidth = 51;
            this.dgvSviArtikli.RowTemplate.Height = 24;
            this.dgvSviArtikli.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSviArtikli.Size = new System.Drawing.Size(583, 202);
            this.dgvSviArtikli.TabIndex = 9;
            // 
            // dgvArtikliHH
            // 
            this.dgvArtikliHH.AllowUserToAddRows = false;
            this.dgvArtikliHH.AllowUserToDeleteRows = false;
            this.dgvArtikliHH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvArtikliHH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArtikliHH.Location = new System.Drawing.Point(38, 45);
            this.dgvArtikliHH.Margin = new System.Windows.Forms.Padding(2);
            this.dgvArtikliHH.MultiSelect = false;
            this.dgvArtikliHH.Name = "dgvArtikliHH";
            this.dgvArtikliHH.ReadOnly = true;
            this.dgvArtikliHH.RowHeadersWidth = 51;
            this.dgvArtikliHH.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArtikliHH.Size = new System.Drawing.Size(583, 190);
            this.dgvArtikliHH.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(231, 17);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Trenutni artikli na happy hour-u";
            // 
            // buttonDodaj
            // 
            this.buttonDodaj.AutoSize = true;
            this.buttonDodaj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(175)))), ((int)(((byte)(175)))));
            this.buttonDodaj.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDodaj.ForeColor = System.Drawing.Color.White;
            this.buttonDodaj.Location = new System.Drawing.Point(296, 590);
            this.buttonDodaj.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDodaj.Name = "buttonDodaj";
            this.buttonDodaj.Size = new System.Drawing.Size(97, 41);
            this.buttonDodaj.TabIndex = 10;
            this.buttonDodaj.Text = "Odaberi";
            this.buttonDodaj.UseVisualStyleBackColor = false;
            this.buttonDodaj.Click += new System.EventHandler(this.buttonDodaj_Click);
            // 
            // buttonMakni
            // 
            this.buttonMakni.AutoSize = true;
            this.buttonMakni.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(175)))), ((int)(((byte)(175)))));
            this.buttonMakni.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMakni.ForeColor = System.Drawing.Color.White;
            this.buttonMakni.Location = new System.Drawing.Point(296, 262);
            this.buttonMakni.Margin = new System.Windows.Forms.Padding(2);
            this.buttonMakni.Name = "buttonMakni";
            this.buttonMakni.Size = new System.Drawing.Size(95, 41);
            this.buttonMakni.TabIndex = 8;
            this.buttonMakni.Text = "Ukloni";
            this.buttonMakni.UseVisualStyleBackColor = false;
            this.buttonMakni.Click += new System.EventHandler(this.buttonMakni_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label3.Location = new System.Drawing.Point(463, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Označite artikl za uklanjanje";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label4.Location = new System.Drawing.Point(482, 577);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Označite artikl za odabir";
            // 
            // HappyHourControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonMakni);
            this.Controls.Add(this.buttonDodaj);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvArtikliHH);
            this.Controls.Add(this.dgvSviArtikli);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "HappyHourControl";
            this.Size = new System.Drawing.Size(669, 652);
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}
