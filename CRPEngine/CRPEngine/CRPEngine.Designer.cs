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
            this.download_msg = new System.Windows.Forms.Label();
            this.printBtn = new System.Windows.Forms.Button();
            this.delete_file = new System.Windows.Forms.Button();
            this.download_btn = new System.Windows.Forms.Button();
            this.messageTextBox = new System.Windows.Forms.RichTextBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
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
            // printBtn
            // 
            this.printBtn.Location = new System.Drawing.Point(409, 46);
            this.printBtn.Name = "printBtn";
            this.printBtn.Size = new System.Drawing.Size(98, 31);
            this.printBtn.TabIndex = 3;
            this.printBtn.Text = "Show Data";
            this.printBtn.UseVisualStyleBackColor = true;
            this.printBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // delete_file
            // 
            this.delete_file.Location = new System.Drawing.Point(409, 83);
            this.delete_file.Name = "delete_file";
            this.delete_file.Size = new System.Drawing.Size(98, 31);
            this.delete_file.TabIndex = 2;
            this.delete_file.Text = "Delete File";
            this.delete_file.UseVisualStyleBackColor = true;
            this.delete_file.Click += new System.EventHandler(this.delete_file_Click);
            // 
            // download_btn
            // 
            this.download_btn.Location = new System.Drawing.Point(409, 9);
            this.download_btn.Name = "download_btn";
            this.download_btn.Size = new System.Drawing.Size(98, 31);
            this.download_btn.TabIndex = 0;
            this.download_btn.Text = "Download";
            this.download_btn.UseVisualStyleBackColor = true;
            this.download_btn.Click += new System.EventHandler(this.download_btn_Click);
            // 
            // messageTextBox
            // 
            this.messageTextBox.AcceptsTab = true;
            this.messageTextBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.messageTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messageTextBox.Location = new System.Drawing.Point(0, 0);
            this.messageTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.messageTextBox.Name = "messageTextBox";
            this.messageTextBox.ReadOnly = true;
            this.messageTextBox.Size = new System.Drawing.Size(395, 576);
            this.messageTextBox.TabIndex = 4;
            this.messageTextBox.Text = "";
            this.messageTextBox.TextChanged += new System.EventHandler(this.messageTextBox_TextChanged);
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(422, 165);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = System.Drawing.Color.Red;
            series1.CustomProperties = "LabelStyle=Left";
            series1.Legend = "Legend1";
            series1.Name = "Job";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(613, 376);
            this.chart1.TabIndex = 5;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(668, 53);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 45);
            this.button1.TabIndex = 6;
            this.button1.Text = "Load Chart";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // CRPEngine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 576);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.messageTextBox);
            this.Controls.Add(this.delete_file);
            this.Controls.Add(this.download_btn);
            this.Controls.Add(this.printBtn);
            this.Controls.Add(this.download_msg);
            this.MaximumSize = new System.Drawing.Size(1080, 1080);
            this.MinimumSize = new System.Drawing.Size(540, 350);
            this.Name = "CRPEngine";
            this.Text = "CRPEngine";
            this.Load += new System.EventHandler(this.CRPEngine_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label download_msg;
        private System.Windows.Forms.Button printBtn;
        private System.Windows.Forms.Button delete_file;
        private System.Windows.Forms.Button download_btn;
        private System.Windows.Forms.RichTextBox messageTextBox;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button button1;
    }
}

