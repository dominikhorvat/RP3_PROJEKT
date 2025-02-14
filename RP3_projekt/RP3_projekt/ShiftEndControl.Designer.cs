﻿namespace RP3_projekt
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
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
            this.shiftBillsView.Location = new System.Drawing.Point(36, 45);
            this.shiftBillsView.MultiSelect = false;
            this.shiftBillsView.Name = "shiftBillsView";
            this.shiftBillsView.ReadOnly = true;
            this.shiftBillsView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.shiftBillsView.Size = new System.Drawing.Size(590, 212);
            this.shiftBillsView.TabIndex = 4;
            this.shiftBillsView.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.shiftBillsView_ColumnHeaderMouseClick);
            // 
            // shiftItemsView
            // 
            this.shiftItemsView.AllowUserToAddRows = false;
            this.shiftItemsView.AllowUserToDeleteRows = false;
            this.shiftItemsView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.shiftItemsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.shiftItemsView.Location = new System.Drawing.Point(36, 330);
            this.shiftItemsView.MultiSelect = false;
            this.shiftItemsView.Name = "shiftItemsView";
            this.shiftItemsView.ReadOnly = true;
            this.shiftItemsView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.shiftItemsView.Size = new System.Drawing.Size(590, 213);
            this.shiftItemsView.TabIndex = 5;
            this.shiftItemsView.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.shiftItemsView_ColumnHeaderMouseClick);
            // 
            // shiftItemsLabel
            // 
            this.shiftItemsLabel.AutoSize = true;
            this.shiftItemsLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shiftItemsLabel.Location = new System.Drawing.Point(33, 311);
            this.shiftItemsLabel.Name = "shiftItemsLabel";
            this.shiftItemsLabel.Size = new System.Drawing.Size(40, 17);
            this.shiftItemsLabel.TabIndex = 3;
            this.shiftItemsLabel.Text = "label";
            // 
            // shiftBillsLabel
            // 
            this.shiftBillsLabel.AutoSize = true;
            this.shiftBillsLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shiftBillsLabel.Location = new System.Drawing.Point(33, 25);
            this.shiftBillsLabel.Name = "shiftBillsLabel";
            this.shiftBillsLabel.Size = new System.Drawing.Size(40, 17);
            this.shiftBillsLabel.TabIndex = 4;
            this.shiftBillsLabel.Text = "label";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.Location = new System.Drawing.Point(32, 587);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(59, 23);
            this.totalLabel.TabIndex = 5;
            this.totalLabel.Text = "label";
            // 
            // logoutBtn
            // 
            this.logoutBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(175)))), ((int)(((byte)(175)))));
            this.logoutBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutBtn.ForeColor = System.Drawing.Color.White;
            this.logoutBtn.Location = new System.Drawing.Point(503, 582);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(123, 39);
            this.logoutBtn.TabIndex = 6;
            this.logoutBtn.Text = "Odjavi se";
            this.logoutBtn.UseVisualStyleBackColor = false;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Location = new System.Drawing.Point(300, 260);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(326, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Za sortiranje tablice kliknite na zaglavlje odabranog stupca";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label2.Location = new System.Drawing.Point(300, 546);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(326, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Za sortiranje tablice kliknite na zaglavlje odabranog stupca";
            // 
            // ShiftEndControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.logoutBtn);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.shiftBillsLabel);
            this.Controls.Add(this.shiftItemsLabel);
            this.Controls.Add(this.shiftItemsView);
            this.Controls.Add(this.shiftBillsView);
            this.Name = "ShiftEndControl";
            this.Size = new System.Drawing.Size(669, 652);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
