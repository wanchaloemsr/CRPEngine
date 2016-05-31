namespace CRPEngine
{
    partial class Unemployed_Rate_Chart
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
            this.UnemployedRateChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.UnemployedRateChart)).BeginInit();
            this.SuspendLayout();
            // 
            // UnemployedRateChart
            // 
            chartArea1.Name = "ChartArea1";
            this.UnemployedRateChart.ChartAreas.Add(chartArea1);
            this.UnemployedRateChart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.UnemployedRateChart.Legends.Add(legend1);
            this.UnemployedRateChart.Location = new System.Drawing.Point(0, 0);
            this.UnemployedRateChart.Name = "UnemployedRateChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            series1.Legend = "Legend1";
            series1.Name = "Unemployed Rate";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            this.UnemployedRateChart.Series.Add(series1);
            this.UnemployedRateChart.Size = new System.Drawing.Size(784, 381);
            this.UnemployedRateChart.TabIndex = 0;
            this.UnemployedRateChart.Text = "Unemployed Rate Chart";
            // 
            // Unemployed_Rate_Chart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 381);
            this.Controls.Add(this.UnemployedRateChart);
            this.Name = "Unemployed_Rate_Chart";
            this.Text = "Unemployed_Rate_Chart";
            ((System.ComponentModel.ISupportInitialize)(this.UnemployedRateChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart UnemployedRateChart;
    }
}