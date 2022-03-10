using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketBuy
{
    class WorkBD
    {
        string connectionString = @"Data Source=(LocalDb)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\DatabaseLogins.mdf;Integrated Security=True";
        public bool userHave(string login)
        {
            int count = 0;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand sqlCom = new SqlCommand($"SELECT Login FROM Logins WHERE Login = '{login}'", connection);
                connection.Open();
                SqlDataReader read = sqlCom.ExecuteReader();
                while (read.Read()) count++;
                if (count > 0) return true;
                else return false;
            }
        }
        public bool userHave(string login, string pass)
        {
            int count = 0;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand sqlCom = new SqlCommand($"SELECT Login FROM Logins WHERE Login = '{login}' AND Password = '{pass}'", connection);
                connection.Open();
                SqlDataReader read = sqlCom.ExecuteReader();
                while (read.Read()) count++;
                if (count > 0) return true;
                else return false;
            }
        }

      
    }
}
