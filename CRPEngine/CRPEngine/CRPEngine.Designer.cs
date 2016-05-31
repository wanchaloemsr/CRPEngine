namespace CRPEngine
{
    partial class CRPEngine
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
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.download_msg = new System.Windows.Forms.Label();
            this.delete_file = new System.Windows.Forms.Button();
            this.download_btn = new System.Windows.Forms.Button();
            this.GoogleTrendsChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.show_chart = new System.Windows.Forms.Button();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.CashRateChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label2 = new System.Windows.Forms.Label();
            this.toDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.unemployedChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.GoogleTrendsChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CashRateChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unemployedChart)).BeginInit();
            this.SuspendLayout();
            // 
            // download_msg
            // 
            this.download_msg.AutoSize = true;
            this.download_msg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.download_msg.Location = new System.Drawing.Point(23, 9);
            this.download_msg.Name = "download_msg";
            this.download_msg.Size = new System.Drawing.Size(9, 20);
            this.download_msg.TabIndex = 1;
            this.download_msg.Text = "\r\n";
            // 
            // delete_file
            // 
            this.delete_file.Location = new System.Drawing.Point(950, 668);
            this.delete_file.Name = "delete_file";
            this.delete_file.Size = new System.Drawing.Size(102, 31);
            this.delete_file.TabIndex = 2;
            this.delete_file.Text = "Delete File";
            this.delete_file.UseVisualStyleBackColor = true;
            this.delete_file.Click += new System.EventHandler(this.delete_file_Click);
            // 
            // download_btn
            // 
            this.download_btn.Location = new System.Drawing.Point(950, 594);
            this.download_btn.Name = "download_btn";
            this.download_btn.Size = new System.Drawing.Size(102, 31);
            this.download_btn.TabIndex = 0;
            this.download_btn.Text = "Download";
            this.download_btn.UseVisualStyleBackColor = true;
            this.download_btn.Click += new System.EventHandler(this.download_btn_Click);
            // 
            // GoogleTrendsChart
            // 
            this.GoogleTrendsChart.AllowDrop = true;
            this.GoogleTrendsChart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            chartArea1.Name = "ChartArea1";
            this.GoogleTrendsChart.ChartAreas.Add(chartArea1);
            this.GoogleTrendsChart.Cursor = System.Windows.Forms.Cursors.Default;
            this.GoogleTrendsChart.Dock = System.Windows.Forms.DockStyle.Top;
            legend1.Name = "Legend1";
            this.GoogleTrendsChart.Legends.Add(legend1);
            this.GoogleTrendsChart.Location = new System.Drawing.Point(0, 0);
            this.GoogleTrendsChart.Name = "GoogleTrendsChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = System.Drawing.Color.Red;
            series1.CustomProperties = "LabelStyle=Center";
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.MarkerSize = 10;
            series1.Name = "Job";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Color = System.Drawing.Color.Blue;
            series2.IsVisibleInLegend = false;
            series2.Legend = "Legend1";
            series2.Name = "Centerlink";
            series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            this.GoogleTrendsChart.Series.Add(series1);
            this.GoogleTrendsChart.Series.Add(series2);
            this.GoogleTrendsChart.Size = new System.Drawing.Size(1064, 240);
            this.GoogleTrendsChart.TabIndex = 5;
            this.GoogleTrendsChart.Text = "GoogleTrends";
            title1.Name = "Google Trends";
            this.GoogleTrendsChart.Titles.Add(title1);
            // 
            // show_chart
            // 
            this.show_chart.Location = new System.Drawing.Point(950, 631);
            this.show_chart.Name = "show_chart";
            this.show_chart.Size = new System.Drawing.Size(102, 31);
            this.show_chart.TabIndex = 7;
            this.show_chart.Text = "Show Chart";
            this.show_chart.UseVisualStyleBackColor = true;
            this.show_chart.Click += new System.EventHandler(this.show_chart_Click);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(185, 9);
            this.dateTimePicker.MaxDate = new System.DateTime(2016, 6, 15, 0, 0, 0, 0);
            this.dateTimePicker.MinDate = new System.DateTime(2004, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(197, 20);
            this.dateTimePicker.TabIndex = 8;
            this.dateTimePicker.Value = new System.DateTime(2004, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Select Date From :";
            // 
            // CashRateChart
            // 
            chartArea2.Name = "ChartArea1";
            this.CashRateChart.ChartAreas.Add(chartArea2);
            this.CashRateChart.Dock = System.Windows.Forms.DockStyle.Bottom;
            legend2.Name = "Legend1";
            this.CashRateChart.Legends.Add(legend2);
            this.CashRateChart.Location = new System.Drawing.Point(0, 481);
            this.CashRateChart.Name = "CashRateChart";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Color = System.Drawing.Color.Fuchsia;
            series3.IsVisibleInLegend = false;
            series3.Legend = "Legend1";
            series3.Name = "Cash Rate";
            series3.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            this.CashRateChart.Series.Add(series3);
            this.CashRateChart.Size = new System.Drawing.Size(1064, 240);
            this.CashRateChart.TabIndex = 10;
            this.CashRateChart.Text = "cashRateChart";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(447, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "To :";
            // 
            // toDateTimePicker
            // 
            this.toDateTimePicker.Location = new System.Drawing.Point(480, 8);
            this.toDateTimePicker.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.toDateTimePicker.MinDate = new System.DateTime(2004, 1, 1, 0, 0, 0, 0);
            this.toDateTimePicker.Name = "toDateTimePicker";
            this.toDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.toDateTimePicker.TabIndex = 12;
            this.toDateTimePicker.Value = new System.DateTime(2016, 5, 31, 17, 20, 48, 0);
            // 
            // unemployedChart
            // 
            chartArea3.Name = "ChartArea1";
            this.unemployedChart.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.unemployedChart.Legends.Add(legend3);
            this.unemployedChart.Location = new System.Drawing.Point(0, 237);
            this.unemployedChart.Name = "unemployedChart";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.IsVisibleInLegend = false;
            series4.Legend = "Legend1";
            series4.Name = "Unemployed Rate";
            series4.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            this.unemployedChart.Series.Add(series4);
            this.unemployedChart.Size = new System.Drawing.Size(1064, 243);
            this.unemployedChart.TabIndex = 13;
            this.unemployedChart.Text = "chart1";
            // 
            // CRPEngine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 721);
            this.Controls.Add(this.unemployedChart);
            this.Controls.Add(this.toDateTimePicker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.show_chart);
            this.Controls.Add(this.delete_file);
            this.Controls.Add(this.download_btn);
            this.Controls.Add(this.GoogleTrendsChart);
            this.Controls.Add(this.download_msg);
            this.Controls.Add(this.CashRateChart);
            this.MaximumSize = new System.Drawing.Size(1080, 1080);
            this.MinimumSize = new System.Drawing.Size(540, 350);
            this.Name = "CRPEngine";
            this.Text = "CRPEngine";
            this.Load += new System.EventHandler(this.CRPEngine_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GoogleTrendsChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CashRateChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unemployedChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label download_msg;
        private System.Windows.Forms.Button delete_file;
        private System.Windows.Forms.Button download_btn;
        private System.Windows.Forms.DataVisualization.Charting.Chart GoogleTrendsChart;
        private System.Windows.Forms.Button show_chart;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart CashRateChart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker toDateTimePicker;
        private System.Windows.Forms.DataVisualization.Charting.Chart unemployedChart;
    }
}

