namespace PersonelUygulaması
{
    partial class FrmGrafik
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.GrfSehir = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.grfMeslekMaas = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.GrfSehir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grfMeslekMaas)).BeginInit();
            this.SuspendLayout();
            // 
            // GrfSehir
            // 
            chartArea1.Name = "ChartArea1";
            this.GrfSehir.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.GrfSehir.Legends.Add(legend1);
            this.GrfSehir.Location = new System.Drawing.Point(12, 12);
            this.GrfSehir.Name = "GrfSehir";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Sehirler";
            this.GrfSehir.Series.Add(series1);
            this.GrfSehir.Size = new System.Drawing.Size(329, 211);
            this.GrfSehir.TabIndex = 0;
            this.GrfSehir.Text = "chart1";
            this.GrfSehir.Click += new System.EventHandler(this.GrfSehir_Click);
            // 
            // grfMeslekMaas
            // 
            chartArea2.Name = "ChartArea1";
            this.grfMeslekMaas.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.grfMeslekMaas.Legends.Add(legend2);
            this.grfMeslekMaas.Location = new System.Drawing.Point(432, 12);
            this.grfMeslekMaas.Name = "grfMeslekMaas";
            this.grfMeslekMaas.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Meslek-Maas";
            this.grfMeslekMaas.Series.Add(series2);
            this.grfMeslekMaas.Size = new System.Drawing.Size(329, 211);
            this.grfMeslekMaas.TabIndex = 1;
            this.grfMeslekMaas.Text = "chart2";
            this.grfMeslekMaas.Click += new System.EventHandler(this.chart2_Click);
            // 
            // FrmGrafik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 261);
            this.Controls.Add(this.grfMeslekMaas);
            this.Controls.Add(this.GrfSehir);
            this.Name = "FrmGrafik";
            this.Text = "FrmGrafik";
            ((System.ComponentModel.ISupportInitialize)(this.GrfSehir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grfMeslekMaas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart GrfSehir;
        private System.Windows.Forms.DataVisualization.Charting.Chart grfMeslekMaas;
    }
}