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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(24, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Svi zaposlenici Caffe bara:";
            // 
            // dataGridViewEmployee
            // 
            this.dataGridViewEmployee.AllowUserToAddRows = false;
            this.dataGridViewEmployee.AllowUserToDeleteRows = false;
            this.dataGridViewEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmployee.Location = new System.Drawing.Point(29, 108);
            this.dataGridViewEmployee.MultiSelect = false;
            this.dataGridViewEmployee.Name = "dataGridViewEmployee";
            this.dataGridViewEmployee.ReadOnly = true;
            this.dataGridViewEmployee.RowHeadersWidth = 51;
            this.dataGridViewEmployee.RowTemplate.Height = 24;
            this.dataGridViewEmployee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewEmployee.Size = new System.Drawing.Size(671, 264);
            this.dataGridViewEmployee.TabIndex = 1;
            // 
            // buttonOtkaz
            // 
            this.buttonOtkaz.AutoSize = true;
            this.buttonOtkaz.BackColor = System.Drawing.Color.LightGray;
            this.buttonOtkaz.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonOtkaz.Location = new System.Drawing.Point(625, 401);
            this.buttonOtkaz.Name = "buttonOtkaz";
            this.buttonOtkaz.Size = new System.Drawing.Size(75, 30);
            this.buttonOtkaz.TabIndex = 2;
            this.buttonOtkaz.Text = "Otkaz";
            this.buttonOtkaz.UseVisualStyleBackColor = false;
            this.buttonOtkaz.Click += new System.EventHandler(this.buttonOtkaz_Click);
            // 
            // buttonZaposli
            // 
            this.buttonZaposli.AutoSize = true;
            this.buttonZaposli.BackColor = System.Drawing.Color.LightGray;
            this.buttonZaposli.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonZaposli.Location = new System.Drawing.Point(579, 530);
            this.buttonZaposli.Name = "buttonZaposli";
            this.buttonZaposli.Size = new System.Drawing.Size(121, 30);
            this.buttonZaposli.TabIndex = 3;
            this.buttonZaposli.Text = "Zaposli novog";
            this.buttonZaposli.UseVisualStyleBackColor = false;
            this.buttonZaposli.Click += new System.EventHandler(this.buttonZaposli_Click);
            // 
            // EmployeeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.buttonZaposli);
            this.Controls.Add(this.buttonOtkaz);
            this.Controls.Add(this.dataGridViewEmployee);
            this.Controls.Add(this.label1);
            this.Name = "EmployeeControl";
            this.Size = new System.Drawing.Size(765, 586);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewEmployee;
        private System.Windows.Forms.Button buttonOtkaz;
        private System.Windows.Forms.Button buttonZaposli;
    }
}
