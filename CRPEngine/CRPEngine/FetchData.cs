using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using System.Reflection;

namespace CRPEngine
{
    class FetchData

    {

        private string download_link = "http://214548.spinetail.cdu.edu.au/portfolio/files/resume.pdf";
        //private string google_job_search_stat = "https://www.google.com/trends/trendsReport?hl=en-AU&q=job&date=today%2012-m&cmpt=q&tz=Etc%2FGMT-9%3A30&tz=Etc%2FGMT-9%3A30&content=1&export=1";
        private WebClient myWebClient;
        private string executableLocation, downloadFileLocation;
        Uri myUri = new Uri("https://www.google.com/trends/trendsReport?hl=en-AU&q=job&date=today%2012-m&cmpt=q&tz=Etc%2FGMT-9%3A30&tz=Etc%2FGMT-9%3A30&content=1&export=1");
        public FetchData()
        {
            myWebClient = new WebClient();
            executableLocation = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            downloadFileLocation = Path.Combine(executableLocation, "download");
        }

        public void downloadData()
        {
            checkDownloadFolder();
            myWebClient.DownloadFile(download_link, Path.Combine(downloadFileLocation, "resume.pdf"));
            //myWebClient.DownloadFile(google_job_search_stat, Path.Combine(downloadFileLocation, "google-job-search-stat.csv"));
            myWebClient.DownloadFileAsync(myUri, Path.Combine(downloadFileLocation, "google-job-search-stat.csv"));
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
