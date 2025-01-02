namespace RP3_projekt
{
    partial class ShiftEndControl
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
            this.shiftBillsView = new System.Windows.Forms.DataGridView();
            this.shiftItemsView = new System.Windows.Forms.DataGridView();
            this.shiftItemsLabel = new System.Windows.Forms.Label();
            this.shiftBillsLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.logoutBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.shiftBillsView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shiftItemsView)).BeginInit();
            this.SuspendLayout();
            // 
            // shiftBillsView
            // 
            this.shiftBillsView.AllowUserToAddRows = false;
            this.shiftBillsView.AllowUserToDeleteRows = false;
            this.shiftBillsView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.shiftBillsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.shiftBillsView.Location = new System.Drawing.Point(36, 61);
            this.shiftBillsView.MultiSelect = false;
            this.shiftBillsView.Name = "shiftBillsView";
            this.shiftBillsView.ReadOnly = true;
            this.shiftBillsView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.shiftBillsView.Size = new System.Drawing.Size(519, 167);
            this.shiftBillsView.TabIndex = 0;
            this.shiftBillsView.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.shiftBillsView_ColumnHeaderMouseClick);
            // 
            // shiftItemsView
            // 
            this.shiftItemsView.AllowUserToAddRows = false;
            this.shiftItemsView.AllowUserToDeleteRows = false;
            this.shiftItemsView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.shiftItemsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.shiftItemsView.Location = new System.Drawing.Point(36, 290);
            this.shiftItemsView.MultiSelect = false;
            this.shiftItemsView.Name = "shiftItemsView";
            this.shiftItemsView.ReadOnly = true;
            this.shiftItemsView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.shiftItemsView.Size = new System.Drawing.Size(519, 167);
            this.shiftItemsView.TabIndex = 2;
            this.shiftItemsView.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.shiftItemsView_ColumnHeaderMouseClick);
            // 
            // shiftItemsLabel
            // 
            this.shiftItemsLabel.AutoSize = true;
            this.shiftItemsLabel.Location = new System.Drawing.Point(33, 260);
            this.shiftItemsLabel.Name = "shiftItemsLabel";
            this.shiftItemsLabel.Size = new System.Drawing.Size(29, 13);
            this.shiftItemsLabel.TabIndex = 3;
            this.shiftItemsLabel.Text = "label";
            // 
            // shiftBillsLabel
            // 
            this.shiftBillsLabel.AutoSize = true;
            this.shiftBillsLabel.Location = new System.Drawing.Point(33, 28);
            this.shiftBillsLabel.Name = "shiftBillsLabel";
            this.shiftBillsLabel.Size = new System.Drawing.Size(29, 13);
            this.shiftBillsLabel.TabIndex = 4;
            this.shiftBillsLabel.Text = "label";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.Location = new System.Drawing.Point(31, 487);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(58, 25);
            this.totalLabel.TabIndex = 5;
            this.totalLabel.Text = "label";
            // 
            // logoutBtn
            // 
            this.logoutBtn.Location = new System.Drawing.Point(480, 491);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(75, 23);
            this.logoutBtn.TabIndex = 6;
            this.logoutBtn.Text = "Odjavi se";
            this.logoutBtn.UseVisualStyleBackColor = true;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // ShiftEndControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.logoutBtn);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.shiftBillsLabel);
            this.Controls.Add(this.shiftItemsLabel);
            this.Controls.Add(this.shiftItemsView);
            this.Controls.Add(this.shiftBillsView);
            this.Name = "ShiftEndControl";
            this.Size = new System.Drawing.Size(592, 578);
            ((System.ComponentModel.ISupportInitialize)(this.shiftBillsView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shiftItemsView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView shiftBillsView;
        private System.Windows.Forms.DataGridView shiftItemsView;
        private System.Windows.Forms.Label shiftItemsLabel;
        private System.Windows.Forms.Label shiftBillsLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Button logoutBtn;
    }
}
