namespace CRPEngine
{
    partial class Cash_Rate_Chart
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
            this.CashRateChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.CashRateChart)).BeginInit();
            this.SuspendLayout();
            // 
            // CashRateChart
            // 
            chartArea1.Name = "ChartArea1";
            this.CashRateChart.ChartAreas.Add(chartArea1);
            this.CashRateChart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.CashRateChart.Legends.Add(legend1);
            this.CashRateChart.Location = new System.Drawing.Point(0, 0);
            this.CashRateChart.Name = "CashRateChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = System.Drawing.Color.Fuchsia;
            series1.Legend = "Legend1";
            series1.Name = "Cash Rate";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            this.CashRateChart.Series.Add(series1);
            this.CashRateChart.Size = new System.Drawing.Size(784, 381);
            this.CashRateChart.TabIndex = 0;
            this.CashRateChart.Text = "CashRateChart";
            // 
            // Cash_Rate_Chart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 381);
            this.Controls.Add(this.CashRateChart);
            this.Name = "Cash_Rate_Chart";
            this.Text = "Cash_Rate_Chart";
            ((System.ComponentModel.ISupportInitialize)(this.CashRateChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart CashRateChart;
    }
}