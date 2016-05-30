using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRPEngine
{
    class GoogleSearchObject
    {

        private DateTime[] dateTime;
        private string[] searchingStat;
        private string searchTerm;

        public GoogleSearchObject(int dateTimeArraySize, int searchStatArraySize, string searchTerm)
        {

            this.dateTime = new DateTime[dateTimeArraySize];
            this.searchingStat = new string[searchStatArraySize];
            this.searchTerm = searchTerm;

        }

        public void addValue(DateTime dateTime, string searchingStat, int index)
        {

            this.dateTime[index] = dateTime;
            this.searchingStat[index] = searchingStat;

        }

        public string getSearchStat(int index)
        {

            return searchingStat[index];

        }

        public DateTime getDateTime(int index)
        {

            return dateTime[index];

        }

        public string getSearchTerm()
        {

            return searchTerm;

        }

    }
}
