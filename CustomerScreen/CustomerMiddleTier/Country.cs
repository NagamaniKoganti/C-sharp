using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerMiddleTier
{
   public class Country
    {
        private int _countrycode;
        private string _countryName;

        public int Countrycode
        {
            get { return _countrycode; }
            set { _countrycode = value; }
        }

        public string CountryName
        {
            get { return _countryName; }
            set { _countryName = value; }
        }
        
    }
}
