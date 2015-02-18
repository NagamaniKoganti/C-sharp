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
        public bool InsertHobby(int CustomerId, int HobbyId)
        {
            CustomerDataAccess cs = new CustomerDataAccess();
            return cs.InsertHobbies(CustomerId, HobbyId);
        }

    }
}
