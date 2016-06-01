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
            FetchData fetchData = new FetchData();
            fetchData.downloadData();
            download_msg.Text = "Database Updated";
            download_msg.Refresh();
        }

        private void delete_file_Click(object sender, EventArgs e)
        {

            LocalFileAccess myFileAccess = new LocalFileAccess();
            string deleteMessage;

            deleteMessage =  myFileAccess.deleteFile();

            download_msg.Text = deleteMessage;
            download_msg.Refresh();
        }
        
        private void CRPEngine_Load(object sender, EventArgs e)
        {



        }

        private void GoogleBtn_Click(object sender, EventArgs e)
        {
            Google_Trends_Chart googleForm = new Google_Trends_Chart(this);
            if (googleForm.Null != 1)
            {
                googleForm.Show();
            }
        }


        private void displayCashRateBtn_Click(object sender, EventArgs e)
        {
            Cash_Rate_Chart crc = new Cash_Rate_Chart(this);
            if (crc.Null != 1)
            {
                crc.Show();
            }
        }

        private void UnemployedRateBtn_Click(object sender, EventArgs e)
        {
            Unemployed_Rate_Chart urc = new Unemployed_Rate_Chart(this);
            if (urc.Null != 1)
            {
                urc.Show();
            }
        }

        private void displayAllBtn_Click(object sender, EventArgs e)
        {
            Google_Trends_Chart googleForm = new Google_Trends_Chart(this);
            if (googleForm.Null != 1)
            {
                googleForm.Show();

                Unemployed_Rate_Chart urc = new Unemployed_Rate_Chart(this);
                if (urc.Null != 1)
                {
                    urc.Show();

                    Cash_Rate_Chart crc = new Cash_Rate_Chart(this);
                    if (crc.Null != 1)
                    {
                        crc.Show();
                    }
                }
            }            
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
