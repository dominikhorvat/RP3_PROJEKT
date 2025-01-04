namespace RP3_projekt
{
    partial class EmployeeControl
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
            this.dataGridViewEmployee = new System.Windows.Forms.DataGridView();
            this.buttonOtkaz = new System.Windows.Forms.Button();
            this.buttonZaposli = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(233, 148);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Svi zaposlenici Caffe bara:";
            // 
            // dataGridViewEmployee
            // 
            this.dataGridViewEmployee.AllowUserToAddRows = false;
            this.dataGridViewEmployee.AllowUserToDeleteRows = false;
            this.dataGridViewEmployee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmployee.Location = new System.Drawing.Point(41, 182);
            this.dataGridViewEmployee.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewEmployee.MultiSelect = false;
            this.dataGridViewEmployee.Name = "dataGridViewEmployee";
            this.dataGridViewEmployee.ReadOnly = true;
            this.dataGridViewEmployee.RowHeadersWidth = 51;
            this.dataGridViewEmployee.RowTemplate.Height = 24;
            this.dataGridViewEmployee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewEmployee.Size = new System.Drawing.Size(592, 214);
            this.dataGridViewEmployee.TabIndex = 1;
            // 
            // buttonOtkaz
            // 
            this.buttonOtkaz.AutoSize = true;
            this.buttonOtkaz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(175)))), ((int)(((byte)(175)))));
            this.buttonOtkaz.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOtkaz.ForeColor = System.Drawing.Color.White;
            this.buttonOtkaz.Location = new System.Drawing.Point(284, 461);
            this.buttonOtkaz.Margin = new System.Windows.Forms.Padding(2);
            this.buttonOtkaz.Name = "buttonOtkaz";
            this.buttonOtkaz.Size = new System.Drawing.Size(115, 46);
            this.buttonOtkaz.TabIndex = 2;
            this.buttonOtkaz.Text = "Otkaz";
            this.buttonOtkaz.UseVisualStyleBackColor = false;
            this.buttonOtkaz.Click += new System.EventHandler(this.buttonOtkaz_Click);
            // 
            // buttonZaposli
            // 
            this.buttonZaposli.AutoSize = true;
            this.buttonZaposli.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(175)))), ((int)(((byte)(175)))));
            this.buttonZaposli.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonZaposli.ForeColor = System.Drawing.Color.White;
            this.buttonZaposli.Location = new System.Drawing.Point(448, 25);
            this.buttonZaposli.Margin = new System.Windows.Forms.Padding(2);
            this.buttonZaposli.Name = "buttonZaposli";
            this.buttonZaposli.Size = new System.Drawing.Size(185, 41);
            this.buttonZaposli.TabIndex = 3;
            this.buttonZaposli.Text = "Dodaj novog konobara";
            this.buttonZaposli.UseVisualStyleBackColor = false;
            this.buttonZaposli.Click += new System.EventHandler(this.buttonZaposli_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label2.Location = new System.Drawing.Point(273, 398);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(360, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Označite zaposlenika za uklanjanje (nije moguće ukloniti vlasnika)";
            // 
            // EmployeeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonZaposli);
            this.Controls.Add(this.buttonOtkaz);
            this.Controls.Add(this.dataGridViewEmployee);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "EmployeeControl";
            this.Size = new System.Drawing.Size(672, 652);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewEmployee;
        private System.Windows.Forms.Button buttonOtkaz;
        private System.Windows.Forms.Button buttonZaposli;
        private System.Windows.Forms.Label label2;
    }
}
