using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

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

            LocalFileAccess myFileAccess = new LocalFileAccess();
            string deleteMessage;

            deleteMessage =  myFileAccess.deleteFile();

            download_msg.Text = deleteMessage;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            progressBar1.Visible = true;
            ExcelReader er = new ExcelReader();
            string[,] message;
            string[,] centerlinkTermData;
            List<GoogleSearchObject> jobTerm, centerlinkTerm;
            er.readingExcel(out jobTerm, out centerlinkTerm);

            showGraph(jobTerm,"Job");
            showGraph(centerlinkTerm, "Centerlink");

            /*
            for (int column = 0; column < 650; column++)
            {
                for(int row = 0; row < 2; row++)
                {
                    messageTextBox.Text = messageTextBox.Text + message[column, row] + ("\t\t");
                    //this.chart1.Series["Job"].Points.AddXY();Centerlink and 

                }
                if(column >= 5 && column <= 650)
                {
                    this.chart1.Series["Job"].Points.AddXY(message[column, 0], message[column, 1]);
                    this.chart1.Series["Centerlink"].Points.AddXY(centerlinkTermData[column, 0], centerlinkTermData[column, 1]);
                }
                
                messageTextBox.Text = messageTextBox.Text + Environment.NewLine;


            } */

            progressBar1.Visible = false;



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

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void showGraph(List<GoogleSearchObject> statList, string term)
        {
            foreach(GoogleSearchObject list in statList)
            {
                if(DateTime.Compare(list.getDateTime(), Convert.ToDateTime("01-01-2013")) > 0){
                    this.chart1.Series[term].Points.AddXY(Convert.ToDateTime(list.getDateTime()), list.getSearchStat());
                }
            }
        }
        

        
    }
}
