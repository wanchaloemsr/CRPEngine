using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using System.Reflection;

using Google.Apis.Services;
using Google.Apis.Discovery;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Util.Store;
using Google.Apis.Analytics.v3;


namespace CRPEngine
{
    class FetchingData

    {
        
        private string cash_rate_link = "http://www.rba.gov.au/statistics/tables/csv/f1.1-data.csv";
        private string unemployment_rate_link = "http://www.abs.gov.au/ausstats/meisubs.NSF/log?openagent&6202001.xls&6202.0&Time%20Series%20Spreadsheet&5220EF9489727EBBCA257FB7001D0359&0&Apr%202016&19.05.2016&Latest";
        private string google_job_search_stat = "https://www.google.com/trends/trendsReport?hl=en-AU&q=job&date=today%2012-m&cmpt=q&tz=Etc%2FGMT-9%3A30&tz=Etc%2FGMT-9%3A30&content=1&export=1";
        private WebClient myWebClient;
        private string executableLocation, downloadFileLocation;
        Uri myUri = new Uri("https://www.google.com/trends/trendsReport?hl=en-AU&q=job&date=today%2012-m&cmpt=q&tz=Etc%2FGMT-9%3A30&tz=Etc%2FGMT-9%3A30&content=1&export=1");


        public FetchingData()
        {
            myWebClient = new WebClient();
            executableLocation = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            downloadFileLocation = Path.Combine(executableLocation, "download");
            
        }

        public void downloadData()
        {
            checkDownloadFolder();
         
            myWebClient.DownloadFile(unemployment_rate_link, Path.Combine(downloadFileLocation, "unemployment-report.xls"));
            myWebClient.DownloadFile(cash_rate_link, Path.Combine(downloadFileLocation, "cash-rate.csv"));
            //myWebClient.DownloadFile(google_job_search_stat, Path.Combine(downloadFileLocation, "google-job-search-stat.csv"));
            //myWebClient.DownloadFileAsync(myUri, Path.Combine(downloadFileLocation, "google-job-search-stat.csv"));
        }

        private void checkDownloadFolder()
        {

            if (!Directory.Exists(downloadFileLocation))
            {
                Directory.CreateDirectory(downloadFileLocation);
            }

        }

    }
}
