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
    public partial class Chart2_Maximised : Form
    {
        private CRPEngine main;
        private double prediction;

        public Chart2_Maximised()
        {
            InitializeComponent();
        }
        public Chart2_Maximised(CRPEngine Main, double Prediction)
        {
            InitializeComponent();
            main = Main;
            prediction = Prediction;
            UpdateChart();
        }

        private void UpdateChart()
        {
            chart2.Series["Cash Rate"].Points.AddXY(0, main.data[3, 0]);
            chart2.Series["Cash Rate"].Points.AddXY(1, main.data[3, 1]);
            chart2.Series["Cash Rate"].Points.AddXY(2, main.data[3, 2]);
            chart2.Series["Prediction"].Points.AddXY(2, main.data[3, 1]);
            chart2.Series["Prediction"].Points.AddXY(3, prediction);
        }

        private void Chart2_Maximised_Load(object sender, EventArgs e)
        {

        }
    }
}
