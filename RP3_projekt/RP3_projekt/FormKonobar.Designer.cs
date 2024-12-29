namespace RP3_projekt
{
    partial class FormKonobar
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelSidebar = new System.Windows.Forms.Panel();
            this.shiftEndBtn = new System.Windows.Forms.Button();
            this.storageBtn = new System.Windows.Forms.Button();
            this.freezerBtn = new System.Windows.Forms.Button();
            this.billsBtn = new System.Windows.Forms.Button();
            this.panelContent = new System.Windows.Forms.Panel();
            this.panelSidebar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSidebar
            // 
            this.panelSidebar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panelSidebar.Controls.Add(this.shiftEndBtn);
            this.panelSidebar.Controls.Add(this.storageBtn);
            this.panelSidebar.Controls.Add(this.freezerBtn);
            this.panelSidebar.Controls.Add(this.billsBtn);
            this.panelSidebar.Location = new System.Drawing.Point(0, 0);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Size = new System.Drawing.Size(194, 688);
            this.panelSidebar.TabIndex = 0;
            // 
            // shiftEndBtn
            // 
            this.shiftEndBtn.Location = new System.Drawing.Point(42, 258);
            this.shiftEndBtn.Name = "shiftEndBtn";
            this.shiftEndBtn.Size = new System.Drawing.Size(110, 41);
            this.shiftEndBtn.TabIndex = 3;
            this.shiftEndBtn.Text = "Kraj smjene";
            this.shiftEndBtn.UseVisualStyleBackColor = true;
            this.shiftEndBtn.Click += new System.EventHandler(this.shiftEndBtn_Click);
            // 
            // storageBtn
            // 
            this.storageBtn.Location = new System.Drawing.Point(42, 186);
            this.storageBtn.Name = "storageBtn";
            this.storageBtn.Size = new System.Drawing.Size(110, 41);
            this.storageBtn.TabIndex = 2;
            this.storageBtn.Text = "Stanje skladišta";
            this.storageBtn.UseVisualStyleBackColor = true;
            this.storageBtn.Click += new System.EventHandler(this.storageBtn_Click);
            // 
            // freezerBtn
            // 
            this.freezerBtn.Location = new System.Drawing.Point(42, 110);
            this.freezerBtn.Name = "freezerBtn";
            this.freezerBtn.Size = new System.Drawing.Size(110, 41);
            this.freezerBtn.TabIndex = 1;
            this.freezerBtn.Text = "Stanje hladnjaka";
            this.freezerBtn.UseVisualStyleBackColor = true;
            this.freezerBtn.Click += new System.EventHandler(this.freezerBtn_Click);
            // 
            // billsBtn
            // 
            this.billsBtn.Location = new System.Drawing.Point(42, 33);
            this.billsBtn.Name = "billsBtn";
            this.billsBtn.Size = new System.Drawing.Size(110, 41);
            this.billsBtn.TabIndex = 0;
            this.billsBtn.Text = "Izdavanje računa";
            this.billsBtn.UseVisualStyleBackColor = true;
            this.billsBtn.Click += new System.EventHandler(this.billsBtn_Click);
            // 
            // panelContent
            // 
            this.panelContent.Location = new System.Drawing.Point(191, 0);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(605, 688);
            this.panelContent.TabIndex = 1;
            // 
            // FormKonobar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 687);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelSidebar);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormKonobar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Forma za konobara";
            this.panelSidebar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.Button shiftEndBtn;
        private System.Windows.Forms.Button storageBtn;
        private System.Windows.Forms.Button freezerBtn;
        private System.Windows.Forms.Button billsBtn;
        private System.Windows.Forms.Panel panelContent;
    }
}