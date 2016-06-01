using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRPEngine.Windows
{
    public partial class CR_Prediction_Module : Form
    {
        public double[,] data = new double[4, 3];
        public int inputRun = 0;
        private double prediction, AUDChange, GDPChange, inflationChange;
        CRPEngine main;

        public CR_Prediction_Module()
        {
            InitializeComponent();
        }
        public CR_Prediction_Module(CRPEngine main)
        {
            InitializeComponent();
            this.main = main;
        }

        private void CR_Prediction_Module_Load(object sender, EventArgs e)
        {
        }

        private void inputDataButton_Click(object sender, EventArgs e)
        {
            Data_Input popup = new Data_Input(this);
            DialogResult dialogresult = popup.ShowDialog();
            popup.Dispose();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void loadChartButton_Click(object sender, EventArgs e)
        {
            if (inputRun == 1)
            {
                //calculate changes in regards to inputs and time
                GDPChange = (data[0, 1] - data[0, 0]) / data[0, 0];
                AUDChange = (((data[2, 1] - data[2, 0]) / data[2, 0]) + ((data[2, 2] - data[2, 1]) / data[2, 1])) / 2;
                inflationChange = (((data[1, 1] - data[1, 0]) / data[1, 0]) + ((data[1, 2] - data[1, 1]) / data[1, 1])) / 2;

                prediction = GDPChange + AUDChange - inflationChange;

                //determine if a change will occur in the cash rate
                if (prediction > 0.5)
                {
                    prediction = data[3, 1] - .025;
                }
                else if (prediction < -0.1)
                {
                    prediction = data[3, 1] + .025;
                }
                else
                {
                    prediction = data[3, 1];
                }

                UpdateChangeLabels();
                UpdateChartData();
            }
        }

        private void chart2_Click(object sender, EventArgs e)
        {

        }

        public void RefreshInputList()
        {
            Inflation.Text = data[1, 0] + ", " + data[1, 1] + ", " + data[1, 2];
            GDP.Text = data[0, 0] + ", " + data[0, 1];
            AUD.Text = data[2, 0] + ", " + data[2, 1] + ", " + data[2, 2];
            CashRate.Text = data[3, 0] + ", " + data[3, 1] + ", " + data[3, 2];
        }

        private void UpdateChartData()
        {
            chart1.Series["GDP"].Points.AddXY(0, data[0, 0]);
            chart1.Series["GDP"].Points.AddXY(1, data[0, 1]);
            chart1.Series["Inflation"].Points.AddXY(0, data[1, 0]);
            chart1.Series["Inflation"].Points.AddXY(1, data[1, 1]);
            chart1.Series["Inflation"].Points.AddXY(2, data[1, 2]);
            chart1.Series["AUD Value"].Points.AddXY(0, data[2, 0]);
            chart1.Series["AUD Value"].Points.AddXY(1, data[2, 1]);
            chart1.Series["AUD Value"].Points.AddXY(2, data[2, 2]);

            chart2.Series["Cash Rate"].Points.AddXY(0, data[3, 0]);
            chart2.Series["Cash Rate"].Points.AddXY(1, data[3, 1]);
            chart2.Series["Cash Rate"].Points.AddXY(2, data[3, 2]);
            chart2.Series["Prediction"].Points.AddXY(2, data[3, 2]);
            chart2.Series["Prediction"].Points.AddXY(3, prediction);
        }

        private void UpdateChangeLabels()
        {
            label4.Text = "Inflation change: " + 100 * ((data[1, 2] - data[1, 0])) + "%";
            label1.Text = "GDP change: " + 100 * ((data[0, 1] - data[0, 0]) / data[0, 0]) + "%";
            label2.Text = "AUD change: " + 100 * ((data[2, 2] - data[2, 0]) / data[2, 0]) + "%";
            label3.Text = "Cash Rate Change: " + 100 * ((data[3, 2] - data[3, 0]) / data[3, 0]) + "%";
            label5.Text = "Predicted Change: " + 100 * (prediction - data[3, 2]) + "%";
        }
    }
}
