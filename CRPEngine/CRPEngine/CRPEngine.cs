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
        
        private void CRPEngine_Load(object sender, EventArgs e)
        {



        }

        private void GoogleBtn_Click(object sender, EventArgs e)
        {
            Google_Trends_Chart googleForm = new Google_Trends_Chart(this);
            googleForm.Show();
        }


        private void displayCashRateBtn_Click(object sender, EventArgs e)
        {
            Cash_Rate_Chart crc = new Cash_Rate_Chart(this);
            crc.Show();
        }

        private void UnemployedRateBtn_Click(object sender, EventArgs e)
        {
            Unemployed_Rate_Chart urc = new Unemployed_Rate_Chart(this);
            urc.Show();
        }

        private void displayAllBtn_Click(object sender, EventArgs e)
        {
            Google_Trends_Chart googleForm = new Google_Trends_Chart(this);
            googleForm.Show();

            Unemployed_Rate_Chart urc = new Unemployed_Rate_Chart(this);
            urc.Show();

            Cash_Rate_Chart crc = new Cash_Rate_Chart(this);
            crc.Show();
        }

        public DateTime getDateFromDTP1()
        {
            return this.dateTimePicker.Value;
        }

        public DateTime getDateFromDTP2()
        {
            return this.toDateTimePicker.Value;
        }


        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
