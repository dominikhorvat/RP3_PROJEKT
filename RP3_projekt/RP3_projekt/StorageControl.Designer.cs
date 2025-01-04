namespace RP3_projekt
{
    partial class StorageControl
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
            this.storageItemsView = new System.Windows.Forms.DataGridView();
            this.itemQuantity = new System.Windows.Forms.NumericUpDown();
            this.addItemBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.storageItemsView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(194, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Odaberite artikl i količinu za dodati u skladište";
            // 
            // storageItemsView
            // 
            this.storageItemsView.AllowUserToAddRows = false;
            this.storageItemsView.AllowUserToDeleteRows = false;
            this.storageItemsView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.storageItemsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.storageItemsView.Location = new System.Drawing.Point(40, 111);
            this.storageItemsView.MultiSelect = false;
            this.storageItemsView.Name = "storageItemsView";
            this.storageItemsView.ReadOnly = true;
            this.storageItemsView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.storageItemsView.Size = new System.Drawing.Size(579, 325);
            this.storageItemsView.TabIndex = 4;
            // 
            // itemQuantity
            // 
            this.itemQuantity.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemQuantity.Location = new System.Drawing.Point(259, 469);
            this.itemQuantity.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.itemQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.itemQuantity.Name = "itemQuantity";
            this.itemQuantity.Size = new System.Drawing.Size(134, 23);
            this.itemQuantity.TabIndex = 5;
            this.itemQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // addItemBtn
            // 
            this.addItemBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(175)))), ((int)(((byte)(175)))));
            this.addItemBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addItemBtn.ForeColor = System.Drawing.Color.White;
            this.addItemBtn.Location = new System.Drawing.Point(244, 508);
            this.addItemBtn.Name = "addItemBtn";
            this.addItemBtn.Size = new System.Drawing.Size(169, 43);
            this.addItemBtn.TabIndex = 6;
            this.addItemBtn.Text = "Dodaj artikl u skladište";
            this.addItemBtn.UseVisualStyleBackColor = false;
            this.addItemBtn.Click += new System.EventHandler(this.addItemBtn_Click);
            // 
            // StorageControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.addItemBtn);
            this.Controls.Add(this.itemQuantity);
            this.Controls.Add(this.storageItemsView);
            this.Controls.Add(this.label1);
            this.Name = "StorageControl";
            this.Size = new System.Drawing.Size(669, 652);
            ((System.ComponentModel.ISupportInitialize)(this.storageItemsView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView storageItemsView;
        private System.Windows.Forms.NumericUpDown itemQuantity;
        private System.Windows.Forms.Button addItemBtn;
    }
}
