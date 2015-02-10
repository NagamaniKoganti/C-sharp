using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomerDATA;
using System.Data;

namespace CustomerMiddleTier
{
    public class Customer
    {
        private int _CustomerId = 0;

        public int CustomerId
        {
            get { return _CustomerId; }
            
        }
       
        private string _CustomerName = "";

        private int _CountryCode;

        private string _Gender = "";

        private bool _Ismarried = false;
        public string CustomerName
        {
            get { return _CustomerName; }
            set
            {
                if (value.Length == 0)
                {
                    throw new Exception("Customer name is required");
                }
                if (value.Length > 20)
                {
                    throw new Exception("Customer name should not exceed 20 characters");
                }
                _CustomerName = value;
            }

        }
        public int CountryCode
        {
            get { return _CountryCode; }
            set { _CountryCode = value; }
        }
        public string Gender
        {
            get { return _Gender; }
            set { _Gender = value; }
        }
        
        
        public bool Ismarried
        {
            get { return _Ismarried; }
            set { _Ismarried = value; }
        }

        public bool saveCustomer()
        {

            CustomerDataAccess customer = new CustomerDataAccess();
            bool IsInserted = customer.AddCustomer(CustomerName, Gender, Ismarried, CountryCode);
            _CustomerId = Convert.ToInt32(customer.GetCustomerDetails(_CustomerName).Tables[0].Rows[0]["ID"]);
            return IsInserted;
        }
        public DataSet LoadCustomer()
        {
            CustomerDataAccess Cust = new CustomerDataAccess();

            return Cust.GetCustomerDetails();
            
        }
        public DataSet LoadCustomer(string Name)
        {
            CustomerDataAccess cus = new CustomerDataAccess();

            return cus.GetCustomerDetails(Name);
        }

        public bool Updatecustomer()
        {
            CustomerDataAccess customer = new CustomerDataAccess();
            bool IsInserted = customer.Updatecustomer(CustomerName, CountryCode, Gender, Ismarried);
            return IsInserted;
        }
        public bool DeleteCustomer()
        {
            CustomerDataAccess custObj = new CustomerDataAccess();
            bool Isdeleted=custObj.DeleteRecord(CustomerName);
            return Isdeleted;
        }
        public DataSet  LoadCountries()
        {
            CustomerDataAccess cd = new CustomerDataAccess();
             return cd.GetCountries();
        }

        
    }


   


  
}
