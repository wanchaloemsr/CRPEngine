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
        

        public void readingExcel()
        {
            Excel.Range range;
            
            int rCount = 0;
            int cCount = 0;

            Excel.Workbook wb = xlApp.Workbooks.Open(Path.GetFullPath("job.csv"));
            Excel.Worksheet ws = (Excel.Worksheet)wb.Worksheets.get_Item(1);
            range = ws.UsedRange;

            for( rCount =1; rCount <= range.Rows.Count; rCount++)
            {
                for (cCount = 1; cCount <= range.Columns.Count; cCount++)
                {
                    object value = (range.Cells[rCount, cCount] as Excel.Range).Value;

                    if (value != null)
                    {
                        if(value.GetType() == typeof(DateTime))
                        {

                            DateTime date = (DateTime)value;
                            Console.WriteLine(date.Date.ToString("d"));
                        }
                        else
                        {
                            Console.WriteLine(value.ToString());
                        }
                        
                    }
                    
                }

            }

        }
        
    }
}
