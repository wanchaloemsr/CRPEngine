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
        public double[,] data = new double[4, 3];

        public CRPEngine()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void download_btn_Click(object sender, EventArgs e)
        {
            FetchData myFetchingData = new FetchData();
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
            string[,] message = null;
            ExcelReader er = new ExcelReader();
            message = er.readExcel();

            if (message != null)
            {
                for (int column = 0; column < 30; column++)
                {
                    for (int row = 0; row < 2; row++)
                    {
                        TextBox.Text = TextBox.Text + message[column, row] + ("\t\t");

                    }

                    TextBox.Text = TextBox.Text + Environment.NewLine;


                }
            }
        }

        private void CRPEngine_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void messageTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            formop
        
            //Data_Input popup = new Data_Input();
            //DialogResult dialogresult = popup.ShowDialog();
            //popup.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void chart2_Click(object sender, EventArgs e)
        {

        }
    }

    public class UpdateData : EventArgs
    {
        double[,] data = new double[4,3];
    }
}
