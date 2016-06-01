using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Net;
using System.Net.Http;
using System.IO;
using System.Reflection;

using Google.Apis.Services;
using Google.Apis.Discovery;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Util.Store;
using Google.Apis.Analytics.v3;


namespace CRPEngine
{
    class FetchData

    {
        
        private string cash_rate_link = "http://www.rba.gov.au/statistics/tables/csv/f1.1-data.csv";
        private string unemployment_rate_link = "http://www.abs.gov.au/ausstats/meisubs.NSF/log?openagent&6202001.xls&6202.0&Time%20Series%20Spreadsheet&5220EF9489727EBBCA257FB7001D0359&0&Apr%202016&19.05.2016&Latest";
        private string test = "https://www.dropbox.com/s/ab25mqt64t0gk2x/report.csv?dl=0";
        private WebClient myWebClient;
        private string executableLocation, downloadFileLocation;
        private CRPEngine main;
        Uri myUri = new Uri("https://www.google.com/trends/trendsReport?hl=en-AU&q=job&date=today%2012-m&cmpt=q&tz=Etc%2FGMT-9%3A30&tz=Etc%2FGMT-9%3A30&content=1&export=1");


        public FetchData()
        {
            myWebClient = new WebClient();
            executableLocation = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            downloadFileLocation = Path.Combine(executableLocation, "download");

        }
        public FetchData(CRPEngine main)
        {
            myWebClient = new WebClient();
            executableLocation = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            downloadFileLocation = Path.Combine(executableLocation, "download");
            this.main = main;
        }

        public async void downloadData()
        {
            try
            {
                checkDownloadFolder();

                await myWebClient.DownloadFileTaskAsync(unemployment_rate_link, Path.Combine(downloadFileLocation, "unemployment-report.xls"));
                await myWebClient.DownloadFileTaskAsync(cash_rate_link, Path.Combine(downloadFileLocation, "cash-rate.csv"));
                await myWebClient.DownloadFileTaskAsync(test, Path.Combine(downloadFileLocation, "google-job-search-stat.csv"));
                //myWebClient.DownloadFileAsync(myUri, Path.Combine(downloadFileLocation, "google-job-search-stat.csv"));
            }
            catch (System.Net.WebException ex)
            {
                Console.WriteLine(ex);
            }

            main.UpdateCompleted();
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
