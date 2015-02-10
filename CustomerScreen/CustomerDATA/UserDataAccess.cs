using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;

namespace CustomerDATA
{
    public class UserDataAccess
    {
        public DataSet CheckUser(string Username, string password)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DBConnection"].ToString();
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            string query = "select *from [User] where User='" + Username + "'and pass='" + password + "'";
            SqlCommand command = new SqlCommand(query, connection);

            DataSet DS = new DataSet();

            SqlDataAdapter Dataadopter = new SqlDataAdapter(command);

            Dataadopter.Fill(DS);
            connection.Close();
            return DS;
        }
    }
}
