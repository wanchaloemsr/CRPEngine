using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRPEngine
{
    class DataObject
    {

        private DateTime dateTime;
        private string searchingStat;
        private string searchTerm;

        public DataObject(string searchTerm)
        {
            
            this.searchTerm = searchTerm;

        }

        public void addValue(DateTime dateTime, string searchingStat)
        {

            this.dateTime = dateTime;
            this.searchingStat = searchingStat;

        }

        public string getSearchStat()
        {

            return searchingStat;

        }

        public DateTime getDateTime()
        {

            return dateTime;

        }

        public string getSearchTerm()
        {

            return searchTerm;

        }

    }
}
