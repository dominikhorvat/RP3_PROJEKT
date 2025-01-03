namespace RP3_projekt
{
    partial class ConsuptionControl
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.monthCalendarPocetak = new System.Windows.Forms.MonthCalendar();
            this.monthCalendarKraj = new System.Windows.Forms.MonthCalendar();
            this.comboBoxArtikl = new System.Windows.Forms.ComboBox();
            this.buttonPrikazi = new System.Windows.Forms.Button();
            this.chartPotrosnjaArtikla = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.labelUkupnaPotrosnja = new System.Windows.Forms.Label();
            this.labelNajviseProdani = new System.Windows.Forms.Label();
            this.labelNajmanjeProdani = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartPotrosnjaArtikla)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(13, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(365, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Konzumacija artikla u određenom vremenu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(12, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Odaberite artikl:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(12, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(197, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Odaberite početni datum:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(374, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(197, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Odaberite završni datum:";
            // 
            // monthCalendarPocetak
            // 
            this.monthCalendarPocetak.Location = new System.Drawing.Point(16, 114);
            this.monthCalendarPocetak.Name = "monthCalendarPocetak";
            this.monthCalendarPocetak.TabIndex = 4;
            // 
            // monthCalendarKraj
            // 
            this.monthCalendarKraj.Location = new System.Drawing.Point(378, 114);
            this.monthCalendarKraj.Name = "monthCalendarKraj";
            this.monthCalendarKraj.TabIndex = 5;
            // 
            // comboBoxArtikl
            // 
            this.comboBoxArtikl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxArtikl.FormattingEnabled = true;
            this.comboBoxArtikl.Location = new System.Drawing.Point(227, 45);
            this.comboBoxArtikl.Name = "comboBoxArtikl";
            this.comboBoxArtikl.Size = new System.Drawing.Size(223, 24);
            this.comboBoxArtikl.TabIndex = 6;
            // 
            // buttonPrikazi
            // 
            this.buttonPrikazi.AutoSize = true;
            this.buttonPrikazi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonPrikazi.Location = new System.Drawing.Point(568, 333);
            this.buttonPrikazi.Name = "buttonPrikazi";
            this.buttonPrikazi.Size = new System.Drawing.Size(75, 30);
            this.buttonPrikazi.TabIndex = 7;
            this.buttonPrikazi.Text = "Prikaži";
            this.buttonPrikazi.UseVisualStyleBackColor = true;
            this.buttonPrikazi.Click += new System.EventHandler(this.buttonPrikazi_Click);
            // 
            // chartPotrosnjaArtikla
            // 
            chartArea3.Name = "ChartArea1";
            this.chartPotrosnjaArtikla.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartPotrosnjaArtikla.Legends.Add(legend3);
            this.chartPotrosnjaArtikla.Location = new System.Drawing.Point(16, 378);
            this.chartPotrosnjaArtikla.Name = "chartPotrosnjaArtikla";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chartPotrosnjaArtikla.Series.Add(series3);
            this.chartPotrosnjaArtikla.Size = new System.Drawing.Size(512, 289);
            this.chartPotrosnjaArtikla.TabIndex = 8;
            this.chartPotrosnjaArtikla.Text = "chart1";
            // 
            // labelUkupnaPotrosnja
            // 
            this.labelUkupnaPotrosnja.AutoSize = true;
            this.labelUkupnaPotrosnja.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelUkupnaPotrosnja.Location = new System.Drawing.Point(13, 692);
            this.labelUkupnaPotrosnja.Name = "labelUkupnaPotrosnja";
            this.labelUkupnaPotrosnja.Size = new System.Drawing.Size(0, 18);
            this.labelUkupnaPotrosnja.TabIndex = 9;
            // 
            // labelNajviseProdani
            // 
            this.labelNajviseProdani.AutoSize = true;
            this.labelNajviseProdani.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelNajviseProdani.Location = new System.Drawing.Point(13, 724);
            this.labelNajviseProdani.Name = "labelNajviseProdani";
            this.labelNajviseProdani.Size = new System.Drawing.Size(0, 18);
            this.labelNajviseProdani.TabIndex = 11;
            // 
            // labelNajmanjeProdani
            // 
            this.labelNajmanjeProdani.AutoSize = true;
            this.labelNajmanjeProdani.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelNajmanjeProdani.Location = new System.Drawing.Point(13, 756);
            this.labelNajmanjeProdani.Name = "labelNajmanjeProdani";
            this.labelNajmanjeProdani.Size = new System.Drawing.Size(0, 18);
            this.labelNajmanjeProdani.TabIndex = 12;
            // 
            // ConsuptionControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelNajmanjeProdani);
            this.Controls.Add(this.labelNajviseProdani);
            this.Controls.Add(this.labelUkupnaPotrosnja);
            this.Controls.Add(this.chartPotrosnjaArtikla);
            this.Controls.Add(this.buttonPrikazi);
            this.Controls.Add(this.comboBoxArtikl);
            this.Controls.Add(this.monthCalendarKraj);
            this.Controls.Add(this.monthCalendarPocetak);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ConsuptionControl";
            this.Size = new System.Drawing.Size(720, 802);
            ((System.ComponentModel.ISupportInitialize)(this.chartPotrosnjaArtikla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MonthCalendar monthCalendarPocetak;
        private System.Windows.Forms.MonthCalendar monthCalendarKraj;
        private System.Windows.Forms.ComboBox comboBoxArtikl;
        private System.Windows.Forms.Button buttonPrikazi;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPotrosnjaArtikla;
        private System.Windows.Forms.Label labelUkupnaPotrosnja;
        private System.Windows.Forms.Label labelNajviseProdani;
        private System.Windows.Forms.Label labelNajmanjeProdani;
    }
}
