using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerScreen
{
    public class Commonode
    {
        public bool CheckValidation(string Customername)
        {
            if(Customername.Length==0)
            {
                return false;
            }
            else
                return true;
        }
    }
}
