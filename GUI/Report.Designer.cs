namespace GUI
{
    partial class Report
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.revenueChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.revenueChart)).BeginInit();
            this.SuspendLayout();
            // 
            // revenueChart
            // 
            chartArea1.Name = "ChartArea1";
            this.revenueChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.revenueChart.Legends.Add(legend1);
            this.revenueChart.Location = new System.Drawing.Point(202, 93);
            this.revenueChart.Name = "revenueChart";
            this.revenueChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Revenue";
            this.revenueChart.Series.Add(series1);
            this.revenueChart.Size = new System.Drawing.Size(814, 559);
            this.revenueChart.TabIndex = 0;
            this.revenueChart.Text = "chart1";
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            title1.Name = "tiltle";
            title1.Text = "YEAR 2018";
            this.revenueChart.Titles.Add(title1);
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.revenueChart);
            this.Name = "Report";
            this.Size = new System.Drawing.Size(1160, 768);
            ((System.ComponentModel.ISupportInitialize)(this.revenueChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart revenueChart;
    }
}
