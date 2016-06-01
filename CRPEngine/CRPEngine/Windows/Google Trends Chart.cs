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

    public partial class Google_Trends_Chart : Form
    {
        public int Null = 0;
        private List<DataObject> jobTerm, centerlinkTerm;
        private CRPEngine CE;

        public Google_Trends_Chart(CRPEngine CE)
        {
            InitializeComponent();
            this.CE = CE;
            ExcelReader er = new ExcelReader(out jobTerm, out centerlinkTerm);

            clearChart();

            if (jobTerm == null || jobTerm.Count < 1 || centerlinkTerm == null || centerlinkTerm.Count < 1)
            {
                Null = 1;
                this.Dispose();
            }
            else
            {
                showGoogleGraph(jobTerm, "Job");
                showGoogleGraph(centerlinkTerm, "Centerlink");
            }
        }

        private void showGoogleGraph(List<DataObject> statList, string term)
        {


            foreach (DataObject list in statList)
            {
                //Console.WriteLine(CE.getDateFromDTP1());

                if (DateTime.Compare(list.getDateTime(), CE.getDateFromDTP1()) >= 0 && DateTime.Compare(list.getDateTime(), CE.getDateFromDTP2()) < 0)
                {
                    this.chart1.Series[term].Points.AddXY(Convert.ToDateTime(list.getDateTime()), list.getSearchStat());
                    this.chart1.Series[term].IsVisibleInLegend = true;
                }
                
            }


        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void clearChart()
        {
            foreach (var series in this.chart1.Series)
            {
                series.Points.Clear();
            }
            
        }
    }
}
