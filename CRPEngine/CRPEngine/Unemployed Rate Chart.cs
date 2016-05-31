﻿using System;
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


    public partial class Unemployed_Rate_Chart : Form
    {

        private List<DataObject> unemployList;
        private CRPEngine CE;

        public Unemployed_Rate_Chart(CRPEngine CE)
        {
            InitializeComponent();
            this.CE = CE;

            ExcelReader er = new ExcelReader(out unemployList, "Unemployed Rate");

            clearChart();
            showUnemployedGraph(unemployList, "Unemployed Rate");

        }

        private void showUnemployedGraph(List<DataObject> unemployList, string term)
        {
            foreach (DataObject list in unemployList)
            {

                if (DateTime.Compare(list.getDateTime(), CE.getDateFromDTP1()) >= 0 && DateTime.Compare(list.getDateTime(), CE.getDateFromDTP2()) < 0)
                {
                    this.UnemployedRateChart.Series[term].Points.AddXY(Convert.ToDateTime(list.getDateTime()), list.getSearchStat());
                    this.UnemployedRateChart.Series[term].IsVisibleInLegend = true;
                }
            }
        }

        private void clearChart()
        {
            foreach (var series in this.UnemployedRateChart.Series)
            {
                series.Points.Clear();
            }
        }
    }
}
