namespace RP3_projekt
{
    partial class ManagementControl
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
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewChangePrice = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPotvrdiCijenu = new System.Windows.Forms.Button();
            this.btnUkloniOdabranog = new System.Windows.Forms.Button();
            this.textBoxPromjenaCijene = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChangePrice)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(44, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(361, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Promijeni cijenu artikla ili ukloni artikl iz ponude";
            // 
            // dataGridViewChangePrice
            // 
            this.dataGridViewChangePrice.AllowUserToAddRows = false;
            this.dataGridViewChangePrice.AllowUserToDeleteRows = false;
            this.dataGridViewChangePrice.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewChangePrice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewChangePrice.Location = new System.Drawing.Point(44, 49);
            this.dataGridViewChangePrice.MultiSelect = false;
            this.dataGridViewChangePrice.Name = "dataGridViewChangePrice";
            this.dataGridViewChangePrice.ReadOnly = true;
            this.dataGridViewChangePrice.RowHeadersWidth = 51;
            this.dataGridViewChangePrice.RowTemplate.Height = 24;
            this.dataGridViewChangePrice.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewChangePrice.Size = new System.Drawing.Size(806, 438);
            this.dataGridViewChangePrice.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(44, 509);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(300, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Odredite novu cijenu odabranog artikla:";
            // 
            // btnPotvrdiCijenu
            // 
            this.btnPotvrdiCijenu.AutoSize = true;
            this.btnPotvrdiCijenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPotvrdiCijenu.Location = new System.Drawing.Point(730, 505);
            this.btnPotvrdiCijenu.Name = "btnPotvrdiCijenu";
            this.btnPotvrdiCijenu.Size = new System.Drawing.Size(120, 30);
            this.btnPotvrdiCijenu.TabIndex = 6;
            this.btnPotvrdiCijenu.Text = "Potvrdi cijenu";
            this.btnPotvrdiCijenu.UseVisualStyleBackColor = true;
            this.btnPotvrdiCijenu.Click += new System.EventHandler(this.btnPotvrdiCijenu_Click);
            // 
            // btnUkloniOdabranog
            // 
            this.btnUkloniOdabranog.AutoSize = true;
            this.btnUkloniOdabranog.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnUkloniOdabranog.Location = new System.Drawing.Point(702, 557);
            this.btnUkloniOdabranog.Name = "btnUkloniOdabranog";
            this.btnUkloniOdabranog.Size = new System.Drawing.Size(148, 30);
            this.btnUkloniOdabranog.TabIndex = 7;
            this.btnUkloniOdabranog.Text = "Ukloni odabranog";
            this.btnUkloniOdabranog.UseVisualStyleBackColor = true;
            this.btnUkloniOdabranog.Click += new System.EventHandler(this.btnUkloniOdabranog_Click);
            // 
            // textBoxPromjenaCijene
            // 
            this.textBoxPromjenaCijene.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxPromjenaCijene.Location = new System.Drawing.Point(406, 507);
            this.textBoxPromjenaCijene.Name = "textBoxPromjenaCijene";
            this.textBoxPromjenaCijene.Size = new System.Drawing.Size(162, 27);
            this.textBoxPromjenaCijene.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(574, 509);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "eura (€)";
            // 
            // ManagementControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxPromjenaCijene);
            this.Controls.Add(this.btnUkloniOdabranog);
            this.Controls.Add(this.btnPotvrdiCijenu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridViewChangePrice);
            this.Controls.Add(this.label2);
            this.Name = "ManagementControl";
            this.Size = new System.Drawing.Size(909, 638);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChangePrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewChangePrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnPotvrdiCijenu;
        private System.Windows.Forms.Button btnUkloniOdabranog;
        private System.Windows.Forms.TextBox textBoxPromjenaCijene;
        private System.Windows.Forms.Label label4;
    }
}
