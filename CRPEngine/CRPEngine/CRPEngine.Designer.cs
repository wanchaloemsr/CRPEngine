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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.download_msg = new System.Windows.Forms.Label();
            this.printBtn = new System.Windows.Forms.Button();
            this.delete_file = new System.Windows.Forms.Button();
            this.download_btn = new System.Windows.Forms.Button();
            this.TextBox = new System.Windows.Forms.RichTextBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.inputDataButton = new System.Windows.Forms.Button();
            this.loadChartButton = new System.Windows.Forms.Button();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.SuspendLayout();
            // 
            // download_msg
            // 
            this.download_msg.AutoSize = true;
            this.download_msg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.download_msg.Location = new System.Drawing.Point(31, 11);
            this.download_msg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.download_msg.Name = "download_msg";
            this.download_msg.Size = new System.Drawing.Size(12, 25);
            this.download_msg.TabIndex = 1;
            this.download_msg.Text = "\r\n";
            // 
            // printBtn
            // 
            this.printBtn.Location = new System.Drawing.Point(545, 57);
            this.printBtn.Margin = new System.Windows.Forms.Padding(4);
            this.printBtn.Name = "printBtn";
            this.printBtn.Size = new System.Drawing.Size(131, 38);
            this.printBtn.TabIndex = 3;
            this.printBtn.Text = "Show Data";
            this.printBtn.UseVisualStyleBackColor = true;
            this.printBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // delete_file
            // 
            this.delete_file.Location = new System.Drawing.Point(545, 102);
            this.delete_file.Margin = new System.Windows.Forms.Padding(4);
            this.delete_file.Name = "delete_file";
            this.delete_file.Size = new System.Drawing.Size(131, 38);
            this.delete_file.TabIndex = 2;
            this.delete_file.Text = "Delete File";
            this.delete_file.UseVisualStyleBackColor = true;
            this.delete_file.Click += new System.EventHandler(this.delete_file_Click);
            // 
            // download_btn
            // 
            this.download_btn.Location = new System.Drawing.Point(545, 11);
            this.download_btn.Margin = new System.Windows.Forms.Padding(4);
            this.download_btn.Name = "download_btn";
            this.download_btn.Size = new System.Drawing.Size(131, 38);
            this.download_btn.TabIndex = 0;
            this.download_btn.Text = "Download";
            this.download_btn.UseVisualStyleBackColor = true;
            this.download_btn.Click += new System.EventHandler(this.download_btn_Click);
            // 
            // TextBox
            // 
            this.TextBox.AcceptsTab = true;
            this.TextBox.Location = new System.Drawing.Point(524, 159);
            this.TextBox.Margin = new System.Windows.Forms.Padding(4);
            this.TextBox.Name = "TextBox";
            this.TextBox.ReadOnly = true;
            this.TextBox.Size = new System.Drawing.Size(289, 153);
            this.TextBox.TabIndex = 4;
            this.TextBox.Text = "";
            this.TextBox.TextChanged += new System.EventHandler(this.messageTextBox_TextChanged);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(12, 12);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "GDP";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "AUD Value";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.Name = "Inflation";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(478, 300);
            this.chart1.TabIndex = 5;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // inputDataButton
            // 
            this.inputDataButton.Location = new System.Drawing.Point(703, 11);
            this.inputDataButton.Margin = new System.Windows.Forms.Padding(4);
            this.inputDataButton.Name = "inputDataButton";
            this.inputDataButton.Size = new System.Drawing.Size(131, 38);
            this.inputDataButton.TabIndex = 6;
            this.inputDataButton.Text = "Input Datra";
            this.inputDataButton.UseVisualStyleBackColor = true;
            this.inputDataButton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // loadChartButton
            // 
            this.loadChartButton.Location = new System.Drawing.Point(703, 57);
            this.loadChartButton.Margin = new System.Windows.Forms.Padding(4);
            this.loadChartButton.Name = "loadChartButton";
            this.loadChartButton.Size = new System.Drawing.Size(131, 38);
            this.loadChartButton.TabIndex = 7;
            this.loadChartButton.Text = "Load chart";
            this.loadChartButton.UseVisualStyleBackColor = true;
            this.loadChartButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // chart2
            // 
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(12, 309);
            this.chart2.Name = "chart2";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Legend = "Legend1";
            series4.Name = "Cash Rate";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.Color = System.Drawing.Color.Red;
            series5.Legend = "Legend1";
            series5.Name = "Prediction";
            this.chart2.Series.Add(series4);
            this.chart2.Series.Add(series5);
            this.chart2.Size = new System.Drawing.Size(478, 178);
            this.chart2.TabIndex = 8;
            this.chart2.Text = "chart2";
            this.chart2.Click += new System.EventHandler(this.chart2_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(67, 4);
            // 
            // CRPEngine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(879, 499);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.loadChartButton);
            this.Controls.Add(this.inputDataButton);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.TextBox);
            this.Controls.Add(this.delete_file);
            this.Controls.Add(this.download_btn);
            this.Controls.Add(this.printBtn);
            this.Controls.Add(this.download_msg);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CRPEngine";
            this.Text = "CRPEngine";
            this.Load += new System.EventHandler(this.CRPEngine_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label download_msg;
        private System.Windows.Forms.Button printBtn;
        private System.Windows.Forms.Button delete_file;
        private System.Windows.Forms.Button download_btn;
        private System.Windows.Forms.RichTextBox TextBox;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button inputDataButton;
        private System.Windows.Forms.Button loadChartButton;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}

