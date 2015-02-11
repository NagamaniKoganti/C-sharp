using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace CustomerDATA
{
    public class CustomerDataAccess
    {
        public bool InsertHobbies(int CustomerId, int HobbyId)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DBConnection"].ToString();
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            string query = "Insert into CustomerHobbies(CustomerId,HobbyID)"+ "values(" + CustomerId + ","+ HobbyId + ")";
            SqlCommand command = new SqlCommand(query, connection);
            int Result = command.ExecuteNonQuery();
            connection.Close();
            if (Result > 0)
            {
                return true;
            }
            else
                return false;
        }

        public DataSet GetHobbies(int CustomerID)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DBConnection"].ToString();
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            string query = "select *from CustomerHobbies where CustomerID=" + CustomerID;
            SqlCommand command = new SqlCommand(query, connection);

            DataSet DS = new DataSet();

            SqlDataAdapter Dataadopter = new SqlDataAdapter(command);

            Dataadopter.Fill(DS);
            connection.Close();
            return DS;
        }
        public DataSet GetHobbies()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DBConnection"].ToString();
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            string query = "select *from HobbyMaster";
            SqlCommand command = new SqlCommand(query, connection);

            DataSet DS = new DataSet();

            SqlDataAdapter Dataadopter = new SqlDataAdapter(command);

            Dataadopter.Fill(DS);
            connection.Close();
            return DS;
        }

        public DataSet GetCountries()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DBConnection"].ToString();
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            string query = "select *from CountriesMaster";
            SqlCommand command = new SqlCommand(query, connection);

            DataSet DS = new DataSet();

            SqlDataAdapter Dataadopter = new SqlDataAdapter(command);

            Dataadopter.Fill(DS);
            connection.Close();
            return DS;
        }
        public DataSet GetCustomerDetails(string CustomerCode)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DBConnection"].ToString();
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            string query = "select *from Customer where Name='" + CustomerCode + "'";
            SqlCommand command = new SqlCommand(query, connection);

            DataSet DS = new DataSet();

            SqlDataAdapter Dataadopter = new SqlDataAdapter(command);

            Dataadopter.Fill(DS);
            connection.Close();
            return DS;
            
        }
        public DataSet GetCustomerDetails()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DBConnection"].ToString();
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            string query = "select Customer.ID,Name,Gender,Status,CountriesMaster.CountryName from Customer inner join CountriesMaster on Customer.CountryID=CountriesMaster.ID";
            SqlCommand command = new SqlCommand(query, connection);

            DataSet DS = new DataSet();

            SqlDataAdapter Dataadopter = new SqlDataAdapter(command);

            Dataadopter.Fill(DS);
            connection.Close();
            return DS;

        }

        public bool AddCustomer(string Name, string Gender, bool status, int CountryCode)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DBConnection"].ToString();
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            string query = "Insert into Customer values('" + Name + "','"
                                                           + Gender +"','"
                                                           + status + "','" + CountryCode + "')";
            SqlCommand command = new SqlCommand(query, connection);
            int Result =command.ExecuteNonQuery();
            connection.Close();
            if (Result > 0)
            {
                return true;
            }
            else
                return false;
        }
        public bool Updatecustomer(string Name, int CountryCode, string Gender, bool status)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DBConnection"].ToString();
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            string query = "Update Customer set Name='"
                             + Name + "',CountryID="
                             + CountryCode + ",Gender='"
                             + Gender + "',status="
                             + Convert.ToInt16(status) + " where Name='" + Name + "'";

            SqlCommand command = new SqlCommand(query, connection);    
            int Result = command.ExecuteNonQuery();
            connection.Close();
            if (Result > 0)
            {
                return true;
            }
            else
                return false;
        }

        public bool DeleteRecord(string Name)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DBConnection"].ToString();
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            string query = "Delete from  Customer where Name='" + Name + "'";

            SqlCommand command = new SqlCommand(query, connection);
            int Result = command.ExecuteNonQuery();
            connection.Close();
            if (Result > 0)
            {
                return true;
            }
            else
                return false;
        }

       
        }


     
}


