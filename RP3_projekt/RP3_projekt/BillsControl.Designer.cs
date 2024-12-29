namespace RP3_projekt
{
    partial class BillsControl
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
            this.printBillBtn = new System.Windows.Forms.Button();
            this.freezerItems = new System.Windows.Forms.ListBox();
            this.addItemBtn = new System.Windows.Forms.Button();
            this.selectedItemsView = new System.Windows.Forms.DataGridView();
            this.deleteItemBtn = new System.Windows.Forms.Button();
            this.employeeDiscount = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelReturn = new System.Windows.Forms.Panel();
            this.finishBillBtn = new System.Windows.Forms.Button();
            this.calculateReturnBtn = new System.Windows.Forms.Button();
            this.forReturn = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.received = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.billTotalPrice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.selectedItemsView)).BeginInit();
            this.panelReturn.SuspendLayout();
            this.SuspendLayout();
            // 
            // printBillBtn
            // 
            this.printBillBtn.Location = new System.Drawing.Point(411, 437);
            this.printBillBtn.Name = "printBillBtn";
            this.printBillBtn.Size = new System.Drawing.Size(111, 46);
            this.printBillBtn.TabIndex = 3;
            this.printBillBtn.Text = "Ispiši račun";
            this.printBillBtn.UseVisualStyleBackColor = true;
            this.printBillBtn.Click += new System.EventHandler(this.printBillBtn_Click);
            // 
            // freezerItems
            // 
            this.freezerItems.FormattingEnabled = true;
            this.freezerItems.Location = new System.Drawing.Point(26, 44);
            this.freezerItems.Name = "freezerItems";
            this.freezerItems.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.freezerItems.Size = new System.Drawing.Size(347, 173);
            this.freezerItems.TabIndex = 4;
            // 
            // addItemBtn
            // 
            this.addItemBtn.Location = new System.Drawing.Point(401, 111);
            this.addItemBtn.Name = "addItemBtn";
            this.addItemBtn.Size = new System.Drawing.Size(101, 45);
            this.addItemBtn.TabIndex = 5;
            this.addItemBtn.Text = "Dodaj artikl";
            this.addItemBtn.UseVisualStyleBackColor = true;
            this.addItemBtn.Click += new System.EventHandler(this.addItemBtn_Click);
            // 
            // selectedItemsView
            // 
            this.selectedItemsView.AllowUserToAddRows = false;
            this.selectedItemsView.AllowUserToDeleteRows = false;
            this.selectedItemsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.selectedItemsView.Location = new System.Drawing.Point(26, 256);
            this.selectedItemsView.Name = "selectedItemsView";
            this.selectedItemsView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.selectedItemsView.Size = new System.Drawing.Size(344, 167);
            this.selectedItemsView.TabIndex = 6;
            // 
            // deleteItemBtn
            // 
            this.deleteItemBtn.Location = new System.Drawing.Point(401, 321);
            this.deleteItemBtn.Name = "deleteItemBtn";
            this.deleteItemBtn.Size = new System.Drawing.Size(101, 45);
            this.deleteItemBtn.TabIndex = 7;
            this.deleteItemBtn.Text = "Ukloni artikl";
            this.deleteItemBtn.UseVisualStyleBackColor = true;
            this.deleteItemBtn.Click += new System.EventHandler(this.deleteItemBtn_Click);
            // 
            // employeeDiscount
            // 
            this.employeeDiscount.AutoSize = true;
            this.employeeDiscount.Location = new System.Drawing.Point(26, 453);
            this.employeeDiscount.Name = "employeeDiscount";
            this.employeeDiscount.Size = new System.Drawing.Size(177, 17);
            this.employeeDiscount.TabIndex = 8;
            this.employeeDiscount.Text = "Dodaj popust zaposlenika (20%)";
            this.employeeDiscount.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(113, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Odaberite artikle koje želite dodati u račun";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(170, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Odabrani artikli";
            // 
            // panelReturn
            // 
            this.panelReturn.Controls.Add(this.finishBillBtn);
            this.panelReturn.Controls.Add(this.calculateReturnBtn);
            this.panelReturn.Controls.Add(this.forReturn);
            this.panelReturn.Controls.Add(this.label3);
            this.panelReturn.Controls.Add(this.received);
            this.panelReturn.Controls.Add(this.label4);
            this.panelReturn.Controls.Add(this.billTotalPrice);
            this.panelReturn.Controls.Add(this.label5);
            this.panelReturn.Location = new System.Drawing.Point(26, 503);
            this.panelReturn.Name = "panelReturn";
            this.panelReturn.Size = new System.Drawing.Size(496, 128);
            this.panelReturn.TabIndex = 11;
            // 
            // finishBillBtn
            // 
            this.finishBillBtn.Location = new System.Drawing.Point(385, 61);
            this.finishBillBtn.Name = "finishBillBtn";
            this.finishBillBtn.Size = new System.Drawing.Size(101, 47);
            this.finishBillBtn.TabIndex = 15;
            this.finishBillBtn.Text = "Završi";
            this.finishBillBtn.UseVisualStyleBackColor = true;
            this.finishBillBtn.Click += new System.EventHandler(this.finishBillBtn_Click);
            // 
            // calculateReturnBtn
            // 
            this.calculateReturnBtn.Location = new System.Drawing.Point(385, 10);
            this.calculateReturnBtn.Name = "calculateReturnBtn";
            this.calculateReturnBtn.Size = new System.Drawing.Size(101, 45);
            this.calculateReturnBtn.TabIndex = 14;
            this.calculateReturnBtn.Text = "Izračunaj ostatak";
            this.calculateReturnBtn.UseVisualStyleBackColor = true;
            this.calculateReturnBtn.Click += new System.EventHandler(this.calculateReturnBtn_Click);
            // 
            // forReturn
            // 
            this.forReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forReturn.Location = new System.Drawing.Point(164, 83);
            this.forReturn.Name = "forReturn";
            this.forReturn.Size = new System.Drawing.Size(128, 30);
            this.forReturn.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "Za vratiti";
            // 
            // received
            // 
            this.received.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.received.Location = new System.Drawing.Point(164, 46);
            this.received.Name = "received";
            this.received.Size = new System.Drawing.Size(128, 30);
            this.received.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Primljeno";
            // 
            // billTotalPrice
            // 
            this.billTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billTotalPrice.Location = new System.Drawing.Point(164, 10);
            this.billTotalPrice.Name = "billTotalPrice";
            this.billTotalPrice.Size = new System.Drawing.Size(128, 30);
            this.billTotalPrice.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Iznos računa";
            // 
            // BillsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelReturn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.employeeDiscount);
            this.Controls.Add(this.deleteItemBtn);
            this.Controls.Add(this.selectedItemsView);
            this.Controls.Add(this.addItemBtn);
            this.Controls.Add(this.freezerItems);
            this.Controls.Add(this.printBillBtn);
            this.Name = "BillsControl";
            this.Size = new System.Drawing.Size(550, 646);
            ((System.ComponentModel.ISupportInitialize)(this.selectedItemsView)).EndInit();
            this.panelReturn.ResumeLayout(false);
            this.panelReturn.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button printBillBtn;
        private System.Windows.Forms.ListBox freezerItems;
        private System.Windows.Forms.Button addItemBtn;
        private System.Windows.Forms.DataGridView selectedItemsView;
        private System.Windows.Forms.Button deleteItemBtn;
        private System.Windows.Forms.CheckBox employeeDiscount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelReturn;
        private System.Windows.Forms.Button finishBillBtn;
        private System.Windows.Forms.Button calculateReturnBtn;
        private System.Windows.Forms.TextBox forReturn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox received;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox billTotalPrice;
        private System.Windows.Forms.Label label5;
    }
}
