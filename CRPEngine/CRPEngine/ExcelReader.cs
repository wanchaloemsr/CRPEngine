using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Excel = Microsoft.Office.Interop.Excel;
using System.Windows.Forms;

namespace CRPEngine
{
    class ExcelReader
    {

        Excel.Application xlApp = new Excel.Application();

        public ExcelReader(out List<DataObject> dataList, string chartCase)
        {
        
            switch (chartCase)
            {
                case "Cash Rate":
                    if (checkFileExist() == true)
                    {
                        cashRateAccess(out dataList, "Cash Rate", "download/cash-rate.csv");
                    }
                    else
                    {
                        dataList = new List<DataObject>();

                        MessageBox.Show("The cash rate report is unavailable, please update the database.");
                    }
                    break;
                case "Unemployment Rate":
                    if (checkFileExist() == true)
                    {
                        UnemploymentRateAccess(out dataList, "Unemployment Rate", "download/unemployment-report.xls");
                    }
                    else
                    {
                        dataList = new List<DataObject>();

                        MessageBox.Show("The unemployment rate report is unavailable, please update the database.");
                    }
                    break;
                default:
                    dataList = new List<DataObject>();
                    break;
            }


        }

        public ExcelReader(out List<DataObject> jobTermObj, out List<DataObject> centerlinkObj)
        {
            if (checkFileExist() == true)
            {
                GoogleDataModifier(out jobTermObj, "Job", "download/job-search-report.csv");
                GoogleDataModifier(out centerlinkObj, "Centerlink", "download/centerlink-search-report.csv");
            }
            else
            {
                jobTermObj = new List<DataObject>();
                centerlinkObj = new List<DataObject>();

                MessageBox.Show("The job trends report is unavailable, please update the database.");
            }



        }



        private void UnemploymentRateAccess(out List<DataObject> dataList, string term, string filePath)
        {

            Excel.Range range;
            Excel.Workbook workBook = xlApp.Workbooks.Open(Path.GetFullPath(filePath));
            Excel.Worksheet workSheet = (Excel.Worksheet)workBook.Worksheets.get_Item(2);
            range = workSheet.UsedRange;

            dataList = new List<DataObject>();
            int col = 0;

            dataList.Clear();

            for (int cCount = 1; cCount <= range.Columns.Count; cCount++)
            {

                object titleValue = (range.Cells[1, cCount] as Excel.Range).Value;

                if (titleValue != null && titleValue.ToString().StartsWith("Unemployed total"))
                {
                    Console.WriteLine("Colonm : {0}", cCount);
                    col = cCount;
                    break;
                }

            }

            for (int rCount = 1; rCount <= range.Rows.Count; rCount++)
            {

                object unemployedValue = (range.Cells[rCount, 1] as Excel.Range).Value;

                if (unemployedValue != null && unemployedValue.GetType() == typeof(DateTime))
                {
                    DataObject unemployedData = new DataObject("Unemployed Rate");

                    unemployedData.addValue(Convert.ToDateTime(unemployedValue), Convert.ToString((range.Cells[rCount, col] as Excel.Range).Value));

                    dataList.Add(unemployedData);
                }

            }

            workBook.Close(0);
            xlApp.Quit();


        }

        private void GoogleDataModifier(out List<DataObject> dataList, string searchTerm, string filePath)
        {

            Excel.Range range;
            Excel.Workbook workBook = xlApp.Workbooks.Open(Path.GetFullPath(filePath));
            Excel.Worksheet workSheet = (Excel.Worksheet)workBook.Worksheets.get_Item(1);
            range = workSheet.UsedRange;

            List<DataObject> weeklyDataList = new List<DataObject>();
            dataList = new List<DataObject>();

            weeklyDataList.Clear();
            dataList.Clear();

            for (int rCount = 1; rCount <= range.Rows.Count; rCount++)
            {
                DataObject tempObj = new DataObject(searchTerm);
                object jobValue = (range.Cells[rCount, 1] as Excel.Range).Value;

                if (jobValue != null && jobValue.ToString().Length >= 10)
                {
                    string extractStr = jobValue.ToString();
                    extractStr = extractStr.Substring(0, 10);

                    if (isDate(extractStr) == true)
                    {
                        tempObj.addValue(Convert.ToDateTime(extractStr), Convert.ToString((range.Cells[rCount, 2] as Excel.Range).Value));

                        weeklyDataList.Add(tempObj);
                    }
                }

            }

            weeklyDataList.RemoveAt(weeklyDataList.Count - 1);

            convertToMonthly(weeklyDataList, out dataList, searchTerm);

            workBook.Close(0);
            xlApp.Quit();

        }

        private void convertToMonthly(List<DataObject> weeklyDataList, out List<DataObject> dataList, string searchTerm)
        {

            dataList = new List<DataObject>();
            dataList.Clear();
            int sum = 0;
            int count = 1;

            for (int i = 0; i < weeklyDataList.Count - 1; i++)
            {


                if (weeklyDataList[i].getDateTime().Month == weeklyDataList[i + 1].getDateTime().Month)
                {
                    sum += Convert.ToInt32(weeklyDataList[i].getSearchStat());
                    count++;
                }

                else
                {
                    DataObject myObj = new DataObject(searchTerm);
                    DateTime dt = new DateTime(weeklyDataList[i].getDateTime().Year, weeklyDataList[i].getDateTime().Month, 1);

                    sum = sum / count;
                    myObj.addValue(dt, sum.ToString());
                    dataList.Add(myObj);

                    sum = 0;
                    count = 1;
                }
            }

        }


        private void cashRateAccess(out List<DataObject> dataList, string searchTerm, string filePath)
        {

            Excel.Range range;
            Excel.Workbook workBook = xlApp.Workbooks.Open(Path.GetFullPath(filePath));
            Excel.Worksheet workSheet = (Excel.Worksheet)workBook.Worksheets.get_Item(1);
            range = workSheet.UsedRange;

            dataList = new List<DataObject>();
            dataList.Clear();

            for (int rCount = 1; rCount <= range.Rows.Count; rCount++)
            {
                DataObject tempObj = new DataObject(searchTerm);
                object cashRateDate = (range.Cells[rCount, 1] as Excel.Range).Value;

                if (cashRateDate != null && cashRateDate.GetType() == typeof(DateTime))
                {

                    object cashRateValue = (range.Cells[rCount, 2] as Excel.Range).Value;

                    if (cashRateValue != null)
                    {

                        tempObj.addValue(Convert.ToDateTime((range.Cells[rCount, 1] as Excel.Range).Value), Convert.ToString((range.Cells[rCount, 2] as Excel.Range).Value));

                        dataList.Add(tempObj);

                    }

                }

            }

            dataList.RemoveAt(dataList.Count - 1);

            workBook.Close(0);
            xlApp.Quit();

        }

        private bool checkFileExist()
        {
            if (File.Exists("download/unemployment-report.xls") == true && File.Exists("download/job-search-report.csv") == true
                && File.Exists("download/centerlink-search-report.csv") == true && File.Exists("download/cash-rate.csv") == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // if a valid date
        private bool isDate(string input)
        {
            DateTime dDate;

            if (DateTime.TryParse(input, out dDate))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
