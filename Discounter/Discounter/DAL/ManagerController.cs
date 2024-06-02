using Domain;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    internal class ManagerController
    {
        public static bool Identificate(string login)
        {
            SqlConnection sqlConnection = new SqlConnection(Common.ConnectionString);
            sqlConnection.Open();
            SqlCommand cmd = sqlConnection.CreateCommand();
            cmd.CommandText = $"SELECT 1 FROM ShopManager WHERE Email = '{login}';";
            var result = cmd.ExecuteScalar();
            sqlConnection.Close();
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
            cmd.CommandText = $"SELECT 1 FROM ShopManager WHERE Email = '{login}' AND Password = '{password}';";
            var result = cmd.ExecuteReader();
            sqlConnection.Close();
            if (!result.HasRows)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static ShopManager GetAdmin(string login, string password)
        {
            SqlConnection sqlConnection = new SqlConnection(Common.ConnectionString);
            sqlConnection.Open();
            SqlCommand cmd = sqlConnection.CreateCommand();
            cmd.CommandText = $"SELECT * FROM ShopManager WHERE Email = '{login}' AND Password = '{password}';";
            var result = cmd.ExecuteReader();
            ShopManager manager = null;
            result.Read();
            manager = new ShopManager(Convert.ToInt32(result["Id"]), result["Name"].ToString(), Enum.Parse<UserRole>(result["Role"].ToString()), result["PhoneNumber"].ToString(), result["Email"].ToString(), "");
            sqlConnection.Close();
            return manager;
        }
    }
}
