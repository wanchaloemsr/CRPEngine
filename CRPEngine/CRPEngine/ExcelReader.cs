using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Excel = Microsoft.Office.Interop.Excel;


namespace CRPEngine
{
    class ExcelReader
    {

        Excel.Application xlApp = new Excel.Application();
        Excel.Application centerlinkXlApp = new Excel.Application();
        Excel.Application cenXlApp = new Excel.Application();

        private GoogleSearchObject centerlinkObj;

        public void readingExcel(out List<GoogleSearchObject> jobTermObj, out List<GoogleSearchObject> centerlinkObj)
        {
            Excel.Range jobRange;
            // Reading Job term stat .csv file from Google
            Excel.Workbook jobWB = xlApp.Workbooks.Open(Path.GetFullPath("download/job-search-report.csv"));
            Excel.Worksheet jobWS = (Excel.Worksheet)jobWB.Worksheets.get_Item(1);
            jobRange = jobWS.UsedRange;


            jobTermObj = new List<GoogleSearchObject>();


            jobTermObj.Clear();
            for (int rCount = 1; rCount <= jobRange.Rows.Count; rCount++)
            {
                GoogleSearchObject tempObj = new GoogleSearchObject("Centerlink");
                object jobValue = (jobRange.Cells[rCount, 1] as Excel.Range).Value;

                if (jobValue != null && jobValue.ToString().Length >= 10)
                {
                    string extractStr = jobValue.ToString();
                    extractStr = extractStr.Substring(0, 10);
                    Console.WriteLine(extractStr);

                    if (isDate(extractStr) == true)
                    {
                        Console.WriteLine(true);
                        Console.WriteLine((jobRange.Cells[rCount, 2] as Excel.Range).Value);
                        tempObj.addValue(Convert.ToDateTime(extractStr), Convert.ToString((jobRange.Cells[rCount, 2] as Excel.Range).Value));

                        jobTermObj.Add(tempObj);
                    }
                }

            }

            jobTermObj.RemoveAt(jobTermObj.Count - 1);

            //string[,] message;
            //message = new string[range.Rows.Count, range.Columns.Count];


            /******************************
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



            *************************************/


            //Reading Centerlink searching stat .csv file from Google

            Excel.Range centerlinkRange;
            Excel.Workbook centerlinkWB = centerlinkXlApp.Workbooks.Open(Path.GetFullPath("download/centerlink-search-report.csv"));
            Excel.Worksheet centerlinkWS = (Excel.Worksheet)centerlinkWB.Worksheets.get_Item(1);
            centerlinkRange = centerlinkWS.UsedRange;

            // string[,] centerlinkData;
            //centerlinkData = new string[centerlinkRange.Rows.Count, centerlinkRange.Columns.Count];

            /*****************************

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
            
            *******************************************/





            /********************************************
            for (rCount = 1; rCount <= centerlinkRange.Rows.Count; rCount++)
            {

                int index = 0;

                Console.WriteLine("Col : {0}", centerlinkRange.Columns.Count);

                for (cCount = 1; cCount <= centerlinkRange.Columns.Count; cCount++)
                {
                    object centerlinkValue = (centerlinkRange.Cells[rCount, cCount] as Excel.Range).Value;

                    if (centerlinkValue != null && centerlinkValue.ToString().Length >=10)
                    {
                        string extractStr = centerlinkValue.ToString();
                        extractStr = extractStr.Substring(0, 10);
                        Console.WriteLine(extractStr);

                        if (isDate(extractStr) == true)
                        {
                            Console.WriteLine(true);
                            //centerlinkObj.addValue()
                        }
                    }

                }
                    

                
            }
            **************************************************************/
            // Centerlink term //

            centerlinkObj = new List<GoogleSearchObject>();
            centerlinkObj.Clear();
            for (int rCount = 1; rCount <= centerlinkRange.Rows.Count; rCount++)
            {
                GoogleSearchObject temp = new GoogleSearchObject("Centerlink");
                object centerlinkValue = (centerlinkRange.Cells[rCount, 1] as Excel.Range).Value;

                if (centerlinkValue != null && centerlinkValue.ToString().Length >= 10)
                {
                    string extractStr = centerlinkValue.ToString();
                    extractStr = extractStr.Substring(0, 10);
                    Console.WriteLine(extractStr);

                    if (isDate(extractStr) == true)
                    {
                        Console.WriteLine(true);
                        Console.WriteLine((centerlinkRange.Cells[rCount, 2] as Excel.Range).Value);
                        temp.addValue(Convert.ToDateTime(extractStr), Convert.ToString((centerlinkRange.Cells[rCount, 2] as Excel.Range).Value));

                        centerlinkObj.Add(temp);
                    }
                }
            }

            centerlinkObj.RemoveAt(centerlinkObj.Count - 1);



            jobWB.Close(0);

            xlApp.Quit();

            centerlinkWB.Close(0);
            centerlinkXlApp.Quit();
            // return message;


        }


        private void GoogleDataModifier(int index)
        {



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

        /*
        private bool isDate(string input)
        {
            DateTime dDate;

            if (DateTime.TryParseExact(input, "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture,
                System.Globalization.DateTimeStyles.None, out dDate))
            {
                return true;
            }
            else
            {
                return false;
            }
        } ********************/
    }
}
