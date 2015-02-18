using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomerDATA;
using System.Data;

namespace CustomerMiddleTier
{
    public class Hobbies
    {
        public DataSet LoadHobbies()
        {
            CustomerDataAccess Cs = new CustomerDataAccess();
            return Cs.GetHobbies();
        }
        public DataSet LoadHobbies(int CustomerID)
        {
            CustomerDataAccess Cs = new CustomerDataAccess();
            return Cs.GetHobbies(CustomerID);
        }
        public bool InsertHobby(int CustomerId, int HobbyId)
        {
            CustomerDataAccess cs = new CustomerDataAccess();
            return cs.InsertHobbies(CustomerId, HobbyId);
        }
        public bool UpdateHobbies(int CustomerId,int HobbyID,bool check)
        {
            if (check)
            {
                
                CustomerDataAccess cs = new CustomerDataAccess();
                if (cs.IsHobbyPresent(CustomerId, HobbyID) == false)
                {
                    cs.InsertHobbies(CustomerId, HobbyID);
                }

            }
            else
            {
                CustomerDataAccess cs = new CustomerDataAccess();
                cs.DeleteHobbies(CustomerId);
            }
            return true;
        }

        public bool deleteHobbies(int customerId)
        {
            CustomerDataAccess cs = new CustomerDataAccess();
            return cs.DeleteHobbies(customerId);
        }
    }
}
