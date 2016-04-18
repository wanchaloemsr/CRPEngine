using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace CRPEngine
{
    class FetchingData

    {

        private string download_link = "http://214548.spinetail.cdu.edu.au/portfolio/files/resume.pdf";
        private WebClient myWebClient;

        public FetchingData()
        {
            myWebClient = new WebClient();
        }

        public void downloadData()
        {

            myWebClient.DownloadFile(download_link, "resume.pdf");

        }

    }
}
