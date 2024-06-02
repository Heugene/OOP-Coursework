using Domain;
using System.Data.Common;
using System.Data.SqlClient;

namespace DAL
{
    public class AdminController
    {
        public static bool Identificate(string login)
        {
            SqlConnection sqlConnection = new SqlConnection(Common.ConnectionString);
            sqlConnection.Open();
            SqlCommand cmd = sqlConnection.CreateCommand();
            cmd.CommandText = $"SELECT 1 FROM Admin WHERE Email = '{login}';";
            var result = cmd.ExecuteScalar();
            if (result is null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool Authentificate(string login, string password)
        {
            SqlConnection sqlConnection = new SqlConnection(Common.ConnectionString);
            sqlConnection.Open();
            SqlCommand cmd = sqlConnection.CreateCommand();
            cmd.CommandText = $"SELECT 1 FROM Admin WHERE Email = '{login}' AND Password = '{password}';";
            var result = cmd.ExecuteReader();
            if (!result.HasRows)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static Admin GetAdmin(string login, string password)
        {
            SqlConnection sqlConnection = new SqlConnection(Common.ConnectionString);
            sqlConnection.Open();
            SqlCommand cmd = sqlConnection.CreateCommand();
            cmd.CommandText = $"SELECT * FROM Admin WHERE Email = '{login}' AND Password = '{password}';";
            var result = cmd.ExecuteReader();
            Admin admin = null;
            result.Read();
            admin = new Admin(Convert.ToInt32(result["Id"]), result["Name"].ToString(), Enum.Parse<UserRole>(result["Role"].ToString()), result["PhoneNumber"].ToString(), result["Email"].ToString(), "");
            return admin;
        }
    }
}
