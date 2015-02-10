using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomerDATA;
using System.Data;
namespace CustomerMiddleTier
    
{
    public class LogInUser
    {
        private string _Username = "";


        private string _Password = "";

        public string Username
        {
            get { return _Username; }
            set { _Username = value; }
        }
        public string Password
        {
            get { return _Password; }
            set { _Password = value; }
        }

        public bool UserCHeck()
        {
            UserDataAccess Us = new UserDataAccess();
            DataSet ds=Us.CheckUser(Username, Password);
            if (ds.Tables[0].Rows.Count == 0)
            {
                return false;

            }
            else
                return true;
            
        }

    }
}
