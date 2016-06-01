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
using CRPEngine.Windows;

namespace CRPEngine
{
    public partial class CRPEngine : Form
    {
        private Google_Trends_Chart googleForm;
        private Unemployed_Rate_Chart urc;
        private Cash_Rate_Chart crc;

        private ExcelReader excelReader;


        public CRPEngine()
        {
            InitializeComponent();
            excelReader = new ExcelReader();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void download_btn_Click(object sender, EventArgs e)
        {
            disableButtons();

            FetchData fetchData = new FetchData(this);
            fetchData.downloadData();
            download_msg.Text = "Database Updating";
            download_msg.Refresh();
        }

        public void UpdateCompleted()
        {
            enableButtons();

            download_msg.Text = "Database Updated";
            download_msg.Refresh();
        }

        private void delete_file_Click(object sender, EventArgs e)
        {

            LocalFileAccess myFileAccess = new LocalFileAccess();
            string deleteMessage;

            deleteMessage = myFileAccess.deleteFile();

            download_msg.Text = deleteMessage;
            download_msg.Refresh();
        }

        private void CRPEngine_Load(object sender, EventArgs e)
        {



        }

        private void GoogleBtn_Click(object sender, EventArgs e)
        {
            if (googleChartWorker.IsBusy != true)
            {
                if (excelReader.checkFileExist() == true)
                {
                    this.progressBar.Style = ProgressBarStyle.Marquee;
                    this.progressBar.MarqueeAnimationSpeed = 2;
                    disableButtons();
                    googleChartWorker.RunWorkerAsync();
                }
                else
                {
                    MessageBox.Show("Some file in the databse is missing or interupted. Please try Updatng the Database.");
                }
            }


        }


        private void displayCashRateBtn_Click(object sender, EventArgs e)
        {
            if (cashRateWorker.IsBusy != true)
            {
                if (excelReader.checkFileExist() == true)
                {
                    this.progressBar.Style = ProgressBarStyle.Marquee;
                    this.progressBar.MarqueeAnimationSpeed = 2;
                    disableButtons();
                    cashRateWorker.RunWorkerAsync();
                }
                else
                {
                    MessageBox.Show("Some file in the databse is missing or interupted. Please try Updatng the Database.");
                }
            }

        }

        private void UnemployedRateBtn_Click(object sender, EventArgs e)
        {
            if (unemploymentWorker.IsBusy != true)
            {
                if (excelReader.checkFileExist() == true)
                {
                    this.progressBar.Style = ProgressBarStyle.Marquee;
                    this.progressBar.MarqueeAnimationSpeed = 2;
                    disableButtons();
                    unemploymentWorker.RunWorkerAsync();
                }
                else
                {
                    MessageBox.Show("Some file in the databse is missing or interupted. Please try Updatng the Database.");
                }

            }
        }

        private void displayAllBtn_Click(object sender, EventArgs e)
        {
            if (cashRateWorker.IsBusy != true || unemploymentWorker.IsBusy != true || googleChartWorker.IsBusy != true)
            {
                if (excelReader.checkFileExist() == true)
                {
                    this.progressBar.Style = ProgressBarStyle.Marquee;
                    this.progressBar.MarqueeAnimationSpeed = 2;
                    disableButtons();
                    cashRateWorker.RunWorkerAsync();
                    unemploymentWorker.RunWorkerAsync();
                    googleChartWorker.RunWorkerAsync();
                }
                else
                {
                    MessageBox.Show("Some file in the databse is missing or interupted. Please try Updatng the Database.");
                }
            }
        }


        private void googleChart_DoWork(object sender, DoWorkEventArgs e)
        {
            googleForm = new Google_Trends_Chart(this);
        }

        private void googleChart_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (googleForm.Null != 1)
            {
                googleForm.Show();
                this.progressBar.Style = ProgressBarStyle.Blocks;
                this.progressBar.Value = 100;
                enableButtons();
            }
        }

        private void unemploymentWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            urc = new Unemployed_Rate_Chart(this);
        }

        private void unemploymentWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (urc.Null != 1)
            {
                urc.Show();
                this.progressBar.Style = ProgressBarStyle.Blocks;
                this.progressBar.Value = 100;
                enableButtons();
            }
        }

        private void cashRateWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            crc = new Cash_Rate_Chart(this);
        }

        private void cashRateWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

            if (crc.Null != 1)
            {
                crc.Show();
                this.progressBar.Style = ProgressBarStyle.Blocks;
                this.progressBar.Value = 100;
                enableButtons();
            }
        }

        private void disableButtons()
        {
            GoogleBtn.Enabled = false;
            displayCashRateBtn.Enabled = false;
            displayAllBtn.Enabled = false;
            UnemployedRateBtn.Enabled = false;
            dateTimePicker.Enabled = false;
            toDateTimePicker.Enabled = false;
        }

        private void enableButtons()
        {
            GoogleBtn.Enabled = true;
            displayCashRateBtn.Enabled = true;
            displayAllBtn.Enabled = true;
            UnemployedRateBtn.Enabled = true;
            dateTimePicker.Enabled = true;
            toDateTimePicker.Enabled = true;
        }

        public DateTime getDateFromDTP1()
        {
            return this.dateTimePicker.Value;
        }

        public DateTime getDateFromDTP2()
        {
            return this.toDateTimePicker.Value;
        }

        public bool getSeekCheck()
        {
            return SeekCheckBox.Checked;
        }

        public bool getJobCheck()
        {
            return jobCheckBox.Checked;
        }

        public bool getCenterlinkCheck()
        {
            return CenterlinkCheckBox.Checked;
        }

<<<<<<< HEAD
        private void predict_cashrate_Click(object sender, EventArgs e)
        {
            CR_Prediction_Module CRPred = new CR_Prediction_Module(this);
            CRPred.Show();
        }
=======
>>>>>>> origin/master
    }
}
