using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Excel = Microsoft.Office.Interop.Excel;


namespace CRPEngine
{
    class ExcelReader
    {

        Excel.Application xlApp = new Excel.Application();


        public void readingExcel(out string[,] message, out string[,] centerlinkData)
        {
            Excel.Range range;
            Excel.Range centerlinkRange;
            
            int rCount = 0;
            int cCount = 0;
            
            
            // Reading Job term stat .csv file from Google
            Excel.Workbook wb = xlApp.Workbooks.Open(Path.GetFullPath("download/job-search-report.csv"));
            Excel.Worksheet ws = (Excel.Worksheet)wb.Worksheets.get_Item(1);
            range = ws.UsedRange;

            //string[,] message;
            message = new string[range.Rows.Count , range.Columns.Count];

            for (rCount = 1; rCount <= 700; rCount++)
            {
                for (cCount = 1; cCount <= range.Columns.Count; cCount++)
                {
                    object value = (range.Cells[rCount, cCount] as Excel.Range).Value;


                    if (value != null)
                    {
                        if (value.GetType() == typeof(DateTime))
                        {

                            DateTime date = (DateTime)value;

                            Console.WriteLine(date.Date.ToString("d"));
                            message[rCount - 1, cCount - 1] = date.Date.ToString("d");
                        }
                        else
                        {
                            Console.WriteLine(value.ToString());
                            message[rCount - 1, cCount - 1] = value.ToString();
                        }


                    }

                }

            }



            //Reading Centerlink searching stat .csv file from Google
            Excel.Workbook centerlinkWB = xlApp.Workbooks.Open(Path.GetFullPath("download/centerlink-search-report.csv"));
            Excel.Worksheet centerlinkWS = (Excel.Worksheet)centerlinkWB.Worksheets.get_Item(1);
            centerlinkRange = centerlinkWS.UsedRange;

            // string[,] centerlinkData;
            centerlinkData = new string[centerlinkRange.Rows.Count, centerlinkRange.Columns.Count];


            for (rCount = 1; rCount <= 700; rCount++)
            {
                for (cCount = 1; cCount <= centerlinkRange.Columns.Count; cCount++)
                {
                    object centerlinkValue = (centerlinkRange.Cells[rCount, cCount] as Excel.Range).Value;


                    if (centerlinkValue != null)
                    {
                        if (centerlinkValue.GetType() == typeof(DateTime))
                        {

                            DateTime date = (DateTime)centerlinkValue;

                            Console.WriteLine(date.Date.ToString("d"));
                            centerlinkData[rCount - 1, cCount - 1] = date.Date.ToString("d");
                        }
                        else
                        {
                            Console.WriteLine(centerlinkValue.ToString());
                            centerlinkData[rCount - 1, cCount - 1] = centerlinkValue.ToString();
                        }


                    }

                }

            }

            wb.Close(0);
            xlApp.Quit();
            // return message;


        }
        
    }
}
