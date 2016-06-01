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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.UnemployedRateChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.UnemployedRateChart)).BeginInit();
            this.SuspendLayout();
            // 
            // UnemployedRateChart
            // 
            chartArea2.Name = "ChartArea1";
            this.UnemployedRateChart.ChartAreas.Add(chartArea2);
            this.UnemployedRateChart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.UnemployedRateChart.Legends.Add(legend2);
            this.UnemployedRateChart.Location = new System.Drawing.Point(0, 0);
            this.UnemployedRateChart.Margin = new System.Windows.Forms.Padding(4);
            this.UnemployedRateChart.Name = "UnemployedRateChart";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            series2.Legend = "Legend1";
            series2.Name = "Unemployment Rate";
            series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            this.UnemployedRateChart.Series.Add(series2);
            this.UnemployedRateChart.Size = new System.Drawing.Size(1045, 469);
            this.UnemployedRateChart.TabIndex = 0;
            this.UnemployedRateChart.Text = "Unemployed Rate Chart";
            this.UnemployedRateChart.Click += new System.EventHandler(this.UnemployedRateChart_Click);
            // 
            // Unemployed_Rate_Chart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 469);
            this.Controls.Add(this.UnemployedRateChart);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Unemployed_Rate_Chart";
            this.Text = "Unemployed_Rate_Chart";
            this.Load += new System.EventHandler(this.Unemployed_Rate_Chart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UnemployedRateChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart UnemployedRateChart;
    }
}