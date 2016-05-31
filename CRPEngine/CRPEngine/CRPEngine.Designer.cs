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
            this.download_msg = new System.Windows.Forms.Label();
            this.delete_file = new System.Windows.Forms.Button();
            this.download_btn = new System.Windows.Forms.Button();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.toDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.GoogleBtn = new System.Windows.Forms.Button();
            this.displayCashRateBtn = new System.Windows.Forms.Button();
            this.UnemployedRateBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.displayAllBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
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
            this.delete_file.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.delete_file.Enabled = false;
            this.delete_file.Location = new System.Drawing.Point(643, 202);
            this.delete_file.Name = "delete_file";
            this.delete_file.Size = new System.Drawing.Size(102, 31);
            this.delete_file.TabIndex = 2;
            this.delete_file.Text = "Delete File";
            this.delete_file.UseVisualStyleBackColor = true;
            this.delete_file.Click += new System.EventHandler(this.delete_file_Click);
            // 
            // download_btn
            // 
            this.download_btn.Location = new System.Drawing.Point(643, 162);
            this.download_btn.Name = "download_btn";
            this.download_btn.Size = new System.Drawing.Size(102, 31);
            this.download_btn.TabIndex = 0;
            this.download_btn.Text = "Update Database";
            this.download_btn.UseVisualStyleBackColor = true;
            this.download_btn.Click += new System.EventHandler(this.download_btn_Click);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker.Location = new System.Drawing.Point(48, 51);
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
            this.label1.Location = new System.Drawing.Point(6, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "From :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(276, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "To :";
            // 
            // toDateTimePicker
            // 
            this.toDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toDateTimePicker.Location = new System.Drawing.Point(308, 51);
            this.toDateTimePicker.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.toDateTimePicker.MinDate = new System.DateTime(2004, 1, 1, 0, 0, 0, 0);
            this.toDateTimePicker.Name = "toDateTimePicker";
            this.toDateTimePicker.Size = new System.Drawing.Size(199, 20);
            this.toDateTimePicker.TabIndex = 12;
            this.toDateTimePicker.Value = new System.DateTime(2016, 5, 31, 17, 20, 48, 0);
            // 
            // GoogleBtn
            // 
            this.GoogleBtn.Location = new System.Drawing.Point(47, 249);
            this.GoogleBtn.Name = "GoogleBtn";
            this.GoogleBtn.Size = new System.Drawing.Size(170, 50);
            this.GoogleBtn.TabIndex = 14;
            this.GoogleBtn.Text = "Display Google Trends Chart";
            this.GoogleBtn.UseVisualStyleBackColor = true;
            this.GoogleBtn.Click += new System.EventHandler(this.GoogleBtn_Click);
            // 
            // displayCashRateBtn
            // 
            this.displayCashRateBtn.Location = new System.Drawing.Point(399, 249);
            this.displayCashRateBtn.Name = "displayCashRateBtn";
            this.displayCashRateBtn.Size = new System.Drawing.Size(170, 50);
            this.displayCashRateBtn.TabIndex = 15;
            this.displayCashRateBtn.Text = "Display Cash Rate Chart";
            this.displayCashRateBtn.UseVisualStyleBackColor = true;
            this.displayCashRateBtn.Click += new System.EventHandler(this.displayCashRateBtn_Click);
            // 
            // UnemployedRateBtn
            // 
            this.UnemployedRateBtn.Location = new System.Drawing.Point(223, 249);
            this.UnemployedRateBtn.Name = "UnemployedRateBtn";
            this.UnemployedRateBtn.Size = new System.Drawing.Size(170, 50);
            this.UnemployedRateBtn.TabIndex = 16;
            this.UnemployedRateBtn.Text = "Display Unemployed Rate Chart";
            this.UnemployedRateBtn.UseVisualStyleBackColor = true;
            this.UnemployedRateBtn.Click += new System.EventHandler(this.UnemployedRateBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(174, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(455, 39);
            this.label3.TabIndex = 17;
            this.label3.Text = "Cash Rate Prediction Engine";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 25);
            this.label4.TabIndex = 18;
            this.label4.Text = "Select time range:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dateTimePicker);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.toDateTimePicker);
            this.groupBox1.Location = new System.Drawing.Point(47, 162);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(522, 81);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            // 
            // displayAllBtn
            // 
            this.displayAllBtn.Location = new System.Drawing.Point(575, 249);
            this.displayAllBtn.Name = "displayAllBtn";
            this.displayAllBtn.Size = new System.Drawing.Size(170, 50);
            this.displayAllBtn.TabIndex = 20;
            this.displayAllBtn.Text = "Display All Chart";
            this.displayAllBtn.UseVisualStyleBackColor = true;
            this.displayAllBtn.Click += new System.EventHandler(this.displayAllBtn_Click);
            // 
            // CRPEngine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 311);
            this.Controls.Add(this.displayAllBtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.UnemployedRateBtn);
            this.Controls.Add(this.displayCashRateBtn);
            this.Controls.Add(this.GoogleBtn);
            this.Controls.Add(this.delete_file);
            this.Controls.Add(this.download_btn);
            this.Controls.Add(this.download_msg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximumSize = new System.Drawing.Size(1080, 1080);
            this.MinimumSize = new System.Drawing.Size(540, 350);
            this.Name = "CRPEngine";
            this.Text = "CRPEngine";
            this.Load += new System.EventHandler(this.CRPEngine_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label download_msg;
        private System.Windows.Forms.Button delete_file;
        private System.Windows.Forms.Button download_btn;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker toDateTimePicker;
        private System.Windows.Forms.Button GoogleBtn;
        private System.Windows.Forms.Button displayCashRateBtn;
        private System.Windows.Forms.Button UnemployedRateBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button displayAllBtn;
    }
}

