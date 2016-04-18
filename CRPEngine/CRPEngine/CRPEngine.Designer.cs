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
            this.download_btn = new System.Windows.Forms.Button();
            this.download_msg = new System.Windows.Forms.Label();
            this.delete_file = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // download_btn
            // 
            this.download_btn.Location = new System.Drawing.Point(213, 253);
            this.download_btn.Name = "download_btn";
            this.download_btn.Size = new System.Drawing.Size(98, 31);
            this.download_btn.TabIndex = 0;
            this.download_btn.Text = "Download";
            this.download_btn.UseVisualStyleBackColor = true;
            this.download_btn.Click += new System.EventHandler(this.download_btn_Click);
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
            this.delete_file.Location = new System.Drawing.Point(317, 253);
            this.delete_file.Name = "delete_file";
            this.delete_file.Size = new System.Drawing.Size(98, 31);
            this.delete_file.TabIndex = 2;
            this.delete_file.Text = "Delete File";
            this.delete_file.UseVisualStyleBackColor = true;
            this.delete_file.Click += new System.EventHandler(this.delete_file_Click);
            // 
            // CRPEngine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 296);
            this.Controls.Add(this.delete_file);
            this.Controls.Add(this.download_msg);
            this.Controls.Add(this.download_btn);
            this.Name = "CRPEngine";
            this.Text = "CRPEngine";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button download_btn;
        private System.Windows.Forms.Label download_msg;
        private System.Windows.Forms.Button delete_file;
    }
}

