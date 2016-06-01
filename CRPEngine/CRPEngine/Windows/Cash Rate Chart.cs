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
    public partial class Cash_Rate_Chart : Form
    {
        public int Null = 0;

        private List<DataObject> cashRateList;
        private CRPEngine CE;

        public Cash_Rate_Chart(CRPEngine CE)
        {
            InitializeComponent();
            this.CE = CE;

            ExcelReader er = new ExcelReader(out cashRateList, "Cash Rate");

            clearChart();

            if (cashRateList == null || cashRateList.Count < 1)
            {
                Null = 1;
                this.Dispose();
            }
            else
            {
                showCashRateGraph(cashRateList, "Cash Rate");
            }

        }

        private void showCashRateGraph(List<DataObject> cashRateList, string term)
        {

            foreach (DataObject list in cashRateList)
            {

                if (DateTime.Compare(list.getDateTime(), CE.getDateFromDTP1()) >= 0 && DateTime.Compare(list.getDateTime(), CE.getDateFromDTP2()) < 0)
                {
                    this.CashRateChart.Series[term].Points.AddXY(Convert.ToDateTime(list.getDateTime()), list.getSearchStat());
                    this.CashRateChart.Series[term].IsVisibleInLegend = true;
                }
            }
        }

        private void clearChart()
        {

            foreach (var series in this.CashRateChart.Series)
            {
                series.Points.Clear();
            }
            
        }

        private void CashRateChart_Click(object sender, EventArgs e)
        {

        }
    }
}
