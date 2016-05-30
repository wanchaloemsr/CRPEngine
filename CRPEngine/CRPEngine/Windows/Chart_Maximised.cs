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
    public partial class Chart1_Maximised : Form
    {
        private CRPEngine main;

        public Chart1_Maximised()
        {
            InitializeComponent();
        }
        public Chart1_Maximised(CRPEngine Main)
        {
            InitializeComponent();
            main = Main;
            UpdateChart();
        }

        private void UpdateChart()
        {
            chart1.Series["GDP"].Points.AddXY(0, main.data[0, 0]);
            chart1.Series["GDP"].Points.AddXY(1, main.data[0, 1]);
            chart1.Series["Inflation"].Points.AddXY(0, main.data[1, 0]);
            chart1.Series["Inflation"].Points.AddXY(1, main.data[1, 1]);
            chart1.Series["Inflation"].Points.AddXY(2, main.data[1, 2]);
            chart1.Series["AUD Value"].Points.AddXY(0, main.data[2, 0]);
            chart1.Series["AUD Value"].Points.AddXY(1, main.data[2, 1]);
            chart1.Series["AUD Value"].Points.AddXY(2, main.data[2, 2]);
        }

        private void Chart1_Maximised_Load(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
