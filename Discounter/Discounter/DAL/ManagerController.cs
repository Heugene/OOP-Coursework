using Domain;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ManagerController
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

        public static ShopManager GetShopManager(string login, string password)
        {
            SqlConnection sqlConnection = new SqlConnection(Common.ConnectionString);
            sqlConnection.Open();
            SqlCommand cmd = sqlConnection.CreateCommand();
            cmd.CommandText = $"SELECT * FROM ShopManager WHERE Email = '{login}' AND Password = '{password}';";
            var result = cmd.ExecuteReader();
            ShopManager manager = null;
            result.Read();
            Shop shop = DAL.ShopController.GetShop(int.Parse(result["ShopID"].ToString()));
            manager = new ShopManager(Convert.ToInt32(result["Id"]), result["Name"].ToString(), Enum.Parse<UserRole>(result["Role"].ToString()), result["PhoneNumber"].ToString(), result["Email"].ToString(), "", shop);
            sqlConnection.Close();
            return manager;
        }


        public static ShopManager CreateShopManager(string name, string phoneNumber, string email, string password, Shop managedShop)
        {
            ShopManager manager = new ShopManager(name, UserRole.ShopManager, phoneNumber, email, password, managedShop);
            SqlConnection sqlConnection = new SqlConnection(Common.ConnectionString);
            sqlConnection.Open();
            SqlCommand cmd = sqlConnection.CreateCommand();
            try
            {
                cmd.CommandText = $"INSERT INTO ShopManager VALUES ('{name}', '{UserRole.ShopManager}', '{email}', '{phoneNumber}', '{password}', {managedShop.ID});";
                cmd.ExecuteNonQuery();
            }
            catch
            {
                manager = null;
            }
            sqlConnection.Close();
            return manager;

        }


        public static bool UpdateShopManager(ShopManager manager, string name, string phoneNumber, string email, string password)
        {
            SqlConnection sqlConnection = new SqlConnection(Common.ConnectionString);
            sqlConnection.Open();
            SqlCommand cmd = sqlConnection.CreateCommand();
            try
            {
                cmd.CommandText = $"UPDATE ShopManager SET Name = '{name}', Email = '{email}', PhoneNumber = '{phoneNumber}', Password = '{password}' WHERE Id = {manager.ID};";
                cmd.ExecuteNonQuery();
                sqlConnection.Close();
                manager.Name = name;
                manager.PhoneNumber = phoneNumber;
                manager.Email = email;
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool ChangePassword(ShopManager manager, string newPassword)
        {
            return UpdateShopManager(manager, manager.Name, manager.PhoneNumber, manager.Email, newPassword);
        }

        public static bool DeleteShopManager(ShopManager manager)
        {
            SqlConnection sqlConnection = new SqlConnection(Common.ConnectionString);
            sqlConnection.Open();
            SqlCommand cmd = sqlConnection.CreateCommand();
            try
            {
                cmd.CommandText = $"DELETE FROM ShopManager WHERE Id = {manager.ID};";
                cmd.ExecuteNonQuery();
                sqlConnection.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
