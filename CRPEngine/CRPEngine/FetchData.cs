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
        private string test = "https://www.dropbox.com/s/ab25mqt64t0gk2x/report.csv?dl=0", google_jobsearch_link = "https://www.google.com/trends/trendsReport?hl=en-AU&q=job&date=today%2012-m&cmpt=q&tz=Etc%2FGMT-9%3A30&tz=Etc%2FGMT-9%3A30&content=1&export=1", google_jobSearch_link = "https://doc-0s-38-docs.googleusercontent.com/docs/securesc/0rek01q5n8u25jdtjeqas9n7orhv15av/cqlhh1jn1urg0hhfrnhm930pg645scnq/1464732000000/01716970933521600829/01716970933521600829/0B0Juehl3NDsOeEpQaDZrSDFrQUU?e=download&nonce=b42eflrro8g4s&user=01716970933521600829&hash=8abvplbl5vsdmgtc47s7jondfc3m072a";
        private WebClient myWebClient;
        private string executableLocation, downloadFileLocation;
        Uri myUri = new Uri("https://www.google.com/trends/trendsReport?hl=en-AU&q=job&date=today%2012-m&cmpt=q&tz=Etc%2FGMT-9%3A30&tz=Etc%2FGMT-9%3A30&content=1&export=1");


        public FetchData()
        {
            myWebClient = new WebClient();
            executableLocation = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            downloadFileLocation = Path.Combine(executableLocation, "download");
            
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
