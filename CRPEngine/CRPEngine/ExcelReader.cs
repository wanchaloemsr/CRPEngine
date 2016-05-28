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
        

        public string[,] readExcel()
        {
            Excel.Range range;
            
            int rCount = 0;
            int cCount = 0;

            string[,] message = null;

            try
            {
                Excel.Workbook wb = xlApp.Workbooks.Open(Path.GetFullPath("job.csv"));
                Excel.Worksheet ws = (Excel.Worksheet)wb.Worksheets.get_Item(1);
                range = ws.UsedRange;
                message = new string[30, range.Columns.Count - 1];

                for (rCount = 1; rCount <= 30; rCount++)
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

                wb.Close(0);
                xlApp.Quit();
            }
            catch (System.Runtime.InteropServices.COMException ex)
            {
                Console.WriteLine(ex);
            }
            
            return message;


        }
        
    }
}
