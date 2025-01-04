namespace RP3_projekt
{
    partial class VlasnikInfoControl
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
            this.labelUputeZaCijenu = new System.Windows.Forms.Label();
            this.labelPotrosnjaInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 10);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Informacije i upute:";
            // 
            // labelUputeZaCijenu
            // 
            this.labelUputeZaCijenu.AutoSize = true;
            this.labelUputeZaCijenu.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUputeZaCijenu.Location = new System.Drawing.Point(21, 50);
            this.labelUputeZaCijenu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelUputeZaCijenu.Name = "labelUputeZaCijenu";
            this.labelUputeZaCijenu.Size = new System.Drawing.Size(0, 20);
            this.labelUputeZaCijenu.TabIndex = 2;
            // 
            // labelPotrosnjaInfo
            // 
            this.labelPotrosnjaInfo.AutoSize = true;
            this.labelPotrosnjaInfo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPotrosnjaInfo.Location = new System.Drawing.Point(21, 132);
            this.labelPotrosnjaInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPotrosnjaInfo.Name = "labelPotrosnjaInfo";
            this.labelPotrosnjaInfo.Size = new System.Drawing.Size(0, 20);
            this.labelPotrosnjaInfo.TabIndex = 3;
            // 
            // VlasnikInfoControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelPotrosnjaInfo);
            this.Controls.Add(this.labelUputeZaCijenu);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "VlasnikInfoControl";
            this.Size = new System.Drawing.Size(669, 652);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelUputeZaCijenu;
        private System.Windows.Forms.Label labelPotrosnjaInfo;
    }
}
