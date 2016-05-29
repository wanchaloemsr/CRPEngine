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
    class FileAccess
    {

        private string executableLoaction;
        private string fileLocation;

        public FileAccess()
        {
            executableLoaction = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            fileLocation = Path.Combine(executableLoaction, "download/resume.pdf");
        }
        

        public string deleteFile()
        {
            if (File.Exists(fileLocation))
            {
                File.Delete(fileLocation);
                return "The file has been deleted..";
            }
            else
            {
                return "The file does not exists..";
            }
        }
    }
}
