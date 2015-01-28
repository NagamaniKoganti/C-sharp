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

            string query = "select *from Customer";
            SqlCommand command = new SqlCommand(query, connection);

            DataSet DS = new DataSet();

            SqlDataAdapter Dataadopter = new SqlDataAdapter(command);

            Dataadopter.Fill(DS);
            connection.Close();
            return DS;

        }

    }
}
