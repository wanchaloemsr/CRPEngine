using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRPEngine
{
    public partial class CRPEngine : Form
    {
        public CRPEngine()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void download_btn_Click(object sender, EventArgs e)
        {
            FetchingData myFetchingData = new FetchingData();
            myFetchingData.downloadData();
            download_msg.Text = "Successfully Downloaded!!";
            
        }

        private void delete_file_Click(object sender, EventArgs e)
        {

            FileAccess myFileAccess = new FileAccess();
            string deleteMessage;

            deleteMessage =  myFileAccess.deleteFile();

            download_msg.Text = deleteMessage;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[,] message;
            ExcelReader er = new ExcelReader();
            message = er.readingExcel();

            for (int column = 0; column < 30; column++)
            {
                for(int row = 0; row < 2; row++)
                {
                    messageTextBox.Text = messageTextBox.Text + message[column, row] + ("\t\t");
                    //this.chart1.Series["Job"].Points.AddXY();

                }
                if(column >= 5 && column <= 30)
                {
                    this.chart1.Series["Job"].Points.AddXY(message[column, 0], message[column, 1]);
                }
                
                messageTextBox.Text = messageTextBox.Text + Environment.NewLine;


            }
            
            
            
        }

        private void CRPEngine_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void messageTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //this.chart1.Series["Job"].Points.AddXY();
        }
    }
}
