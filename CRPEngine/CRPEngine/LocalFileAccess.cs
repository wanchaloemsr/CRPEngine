using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;

using Google.Apis.Auth;

namespace CRPEngine
{
    class LocalFileAccess
    {

        private string executableLoaction;
        private string fileLocation;

        public LocalFileAccess()
        {
            executableLoaction = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            fileLocation = Path.Combine(executableLoaction, "download/");
        }
        

        public string deleteFile()
        {
            if (File.Exists(fileLocation + "cash-rate.csv"))
            {
                File.Delete(fileLocation + "cash-rate.csv");
            }
            if (File.Exists(fileLocation + "google-job-search-stat.csv"))
            {
                File.Delete(fileLocation + "google-job-search-stat.csv");
            }
            if (File.Exists(fileLocation + "unemployment-report.xls"))
            {
                File.Delete(fileLocation + "unemployment-report.xls");
            }

            return "Database wiped";
        }
    }
}
