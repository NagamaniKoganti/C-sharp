using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects
{

       public class Vendor
    {
        private string _Fname;
        private string _Sname;
        private string _Email;
        private string _PhoneNumber;
        private string _Address;
        private string _BusinessName;
        private string _BusinessBanner;

        private string _Weblink;
        public string Fname
        {
            get { return _Fname; }
            set { _Fname = value; }
        }
        
        public string Sname
        {
            get { return _Sname; }
            set { _Sname = value; }
        }
        
        public string Email
        {
            get { return _Email; }
            set { _Email = value; }
        }
        
        public string PhoneNumber
        {
            get { return _PhoneNumber; }
            set { _PhoneNumber = value; }
        }
        
        public string Address
        {
            get { return _Address; }
            set { _Address = value; }
        }
        
        public string BusinessName
        {
            get { return _BusinessName; }
            set { _BusinessName = value; }
        }
        public string BusinessBanner
        {
            get { return _BusinessBanner; }
            set { _BusinessBanner = value; }
        }
        
        public string Weblink
        {
            get { return _Weblink; }
            set { _Weblink = value; }
        }

        public void Addvendor()
        {

        }

        public void Updatevendor()
        {

        }
    }
}
