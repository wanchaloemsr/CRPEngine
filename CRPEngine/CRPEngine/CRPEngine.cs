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
        private double prediction, AUDChange, GDPChange, inflationChange;

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
            Data_Input popup = new Data_Input(this);
            DialogResult dialogresult = popup.ShowDialog();
            popup.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            chart1.Series["GDP"].Points.AddXY(1, data[0, 0]);
            chart1.Series["GDP"].Points.AddXY(2, data[0, 1]);
            chart1.Series["AUD Value"].Points.AddXY(1, data[1, 0]);
            chart1.Series["AUD Value"].Points.AddXY(2, data[1, 1]);
            chart1.Series["AUD Value"].Points.AddXY(3, data[1, 2]);
            chart1.Series["Inflation"].Points.AddXY(1, data[2, 0]);
            chart1.Series["Inflation"].Points.AddXY(2, data[2, 1]);
            chart1.Series["Inflation"].Points.AddXY(3, data[2, 2]);

            //double prediction, AUDChange, GDPChange, inflationChange;
            GDPChange = (data[0, 1] - data[0, 0]) /data[0,0];
            AUDChange = (((data[1, 1] - data[1, 0]) / data[1, 0]) + ((data[1, 2] - data[1, 1]) / data[1, 1])) / 2;
            inflationChange = (((data[2, 1] - data[2, 0]) / data[2, 0]) + ((data[2, 2] - data[2, 1]) / data[2, 1])) / 2;

            prediction = GDPChange + AUDChange - inflationChange;
            
            if (prediction > 0.5)
            {
                prediction = data[0, 1] - .025;
            }
            else if (prediction < -0.1)
            {
                prediction = data[0, 1] + .025;
            }
            else 
            {
                prediction = data[0, 1];
            }

            chart2.Series["Cash Rate"].Points.AddXY(1, data[0, 0]);
            chart2.Series["Cash Rate"].Points.AddXY(2, data[0, 1]);
            chart2.Series["Prediction"].Points.AddXY(2, data[0, 1]);
            chart2.Series["Prediction"].Points.AddXY(3, prediction);
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
