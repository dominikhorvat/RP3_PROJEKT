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
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(177, 48);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(311, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Promijeni cijenu artikla ili ukloni artikl iz ponude";
            // 
            // dataGridViewChangePrice
            // 
            this.dataGridViewChangePrice.AllowUserToAddRows = false;
            this.dataGridViewChangePrice.AllowUserToDeleteRows = false;
            this.dataGridViewChangePrice.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewChangePrice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewChangePrice.Location = new System.Drawing.Point(36, 76);
            this.dataGridViewChangePrice.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewChangePrice.MultiSelect = false;
            this.dataGridViewChangePrice.Name = "dataGridViewChangePrice";
            this.dataGridViewChangePrice.ReadOnly = true;
            this.dataGridViewChangePrice.RowHeadersWidth = 51;
            this.dataGridViewChangePrice.RowTemplate.Height = 24;
            this.dataGridViewChangePrice.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewChangePrice.Size = new System.Drawing.Size(589, 343);
            this.dataGridViewChangePrice.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(91, 448);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(271, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Odredite novu cijenu odabranog artikla:";
            // 
            // btnPotvrdiCijenu
            // 
            this.btnPotvrdiCijenu.AutoSize = true;
            this.btnPotvrdiCijenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(175)))), ((int)(((byte)(175)))));
            this.btnPotvrdiCijenu.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPotvrdiCijenu.ForeColor = System.Drawing.Color.White;
            this.btnPotvrdiCijenu.Location = new System.Drawing.Point(262, 483);
            this.btnPotvrdiCijenu.Margin = new System.Windows.Forms.Padding(2);
            this.btnPotvrdiCijenu.Name = "btnPotvrdiCijenu";
            this.btnPotvrdiCijenu.Size = new System.Drawing.Size(116, 45);
            this.btnPotvrdiCijenu.TabIndex = 9;
            this.btnPotvrdiCijenu.Text = "Potvrdi cijenu";
            this.btnPotvrdiCijenu.UseVisualStyleBackColor = false;
            this.btnPotvrdiCijenu.Click += new System.EventHandler(this.btnPotvrdiCijenu_Click);
            // 
            // btnUkloniOdabranog
            // 
            this.btnUkloniOdabranog.AutoSize = true;
            this.btnUkloniOdabranog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(175)))), ((int)(((byte)(175)))));
            this.btnUkloniOdabranog.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnUkloniOdabranog.ForeColor = System.Drawing.Color.White;
            this.btnUkloniOdabranog.Location = new System.Drawing.Point(246, 578);
            this.btnUkloniOdabranog.Margin = new System.Windows.Forms.Padding(2);
            this.btnUkloniOdabranog.Name = "btnUkloniOdabranog";
            this.btnUkloniOdabranog.Size = new System.Drawing.Size(145, 45);
            this.btnUkloniOdabranog.TabIndex = 10;
            this.btnUkloniOdabranog.Text = "Ukloni odabranog";
            this.btnUkloniOdabranog.UseVisualStyleBackColor = false;
            this.btnUkloniOdabranog.Click += new System.EventHandler(this.btnUkloniOdabranog_Click);
            // 
            // textBoxPromjenaCijene
            // 
            this.textBoxPromjenaCijene.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxPromjenaCijene.Location = new System.Drawing.Point(377, 445);
            this.textBoxPromjenaCijene.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPromjenaCijene.Name = "textBoxPromjenaCijene";
            this.textBoxPromjenaCijene.Size = new System.Drawing.Size(122, 23);
            this.textBoxPromjenaCijene.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(503, 448);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "eura (€)";
            // 
            // ManagementControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxPromjenaCijene);
            this.Controls.Add(this.btnUkloniOdabranog);
            this.Controls.Add(this.btnPotvrdiCijenu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridViewChangePrice);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ManagementControl";
            this.Size = new System.Drawing.Size(669, 652);
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
