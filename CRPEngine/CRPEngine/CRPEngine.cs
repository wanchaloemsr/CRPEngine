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

        List<DataObject> jobTerm, centerlinkTerm, cashRateList, unemployList;


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

        private void show_chart_Click(object sender, EventArgs e)
        {

            ExcelReader er = new ExcelReader(out jobTerm, out centerlinkTerm, out cashRateList, out unemployList);
            
            clearChart();
            showGoogleGraph(jobTerm, "Job");
            showGoogleGraph(centerlinkTerm, "Centerlink");
            showUnemployedGraph(unemployList, "Unemployed Rate");
            showCashRateGraph(cashRateList, "Cash Rate");
            
        }

        private void showUnemployedGraph(List<DataObject> unemployList, string term)
        {
            foreach (DataObject list in unemployList)
            {

                if (DateTime.Compare(list.getDateTime(), this.dateTimePicker.Value) >= 0 && DateTime.Compare(list.getDateTime(), this.toDateTimePicker.Value) < 0)
                {
                    this.unemployedChart.Series[term].Points.AddXY(Convert.ToDateTime(list.getDateTime()), list.getSearchStat());
                    this.unemployedChart.Series[term].IsVisibleInLegend = true;
                }
            }
        }

        private void showCashRateGraph(List<DataObject> cashRateList, string term)
        {

            foreach (DataObject list in cashRateList)
            {

                if (DateTime.Compare(list.getDateTime(), this.dateTimePicker.Value) >= 0 && DateTime.Compare(list.getDateTime(), this.toDateTimePicker.Value) < 0)
                {
                    this.CashRateChart.Series[term].Points.AddXY(Convert.ToDateTime(list.getDateTime()), list.getSearchStat());
                    this.CashRateChart.Series[term].IsVisibleInLegend = true;
                }
            }
        }

        private void CRPEngine_Load(object sender, EventArgs e)
        {



        }
        

        private void showGoogleGraph(List<DataObject> statList, string term)
        {
            

            foreach(DataObject list in statList)
            {
                Console.WriteLine(toDateTimePicker.Value);

                if (DateTime.Compare(list.getDateTime(), this.dateTimePicker.Value) >= 0 && DateTime.Compare(list.getDateTime(), this.toDateTimePicker.Value) < 0)
                {
                    this.GoogleTrendsChart.Series[term].Points.AddXY(Convert.ToDateTime(list.getDateTime()), list.getSearchStat());
                    this.GoogleTrendsChart.Series[term].IsVisibleInLegend = true;
                }
            }


        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void clearChart()
        {
            foreach (var series in this.GoogleTrendsChart.Series)
            {
                series.Points.Clear();
            }

            foreach (var series in this.CashRateChart.Series)
            {
                series.Points.Clear();
            }

            foreach (var series in this.unemployedChart.Series)
            {
                series.Points.Clear();
            }
        }

        
    }
}
