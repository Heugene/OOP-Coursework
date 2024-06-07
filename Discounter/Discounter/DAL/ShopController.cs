using Domain;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DAL
{
    internal class ShopController
    {
        public static Shop CreateShop(Trademark trademark, string address)
        {
            Shop shop = new Shop(trademark, address);
            SqlConnection sqlConnection = new SqlConnection(Common.ConnectionString);
            sqlConnection.Open();
            SqlCommand cmd = sqlConnection.CreateCommand();
            try
            {
                cmd.CommandText = $"INSERT INTO Shop VALUES ({address}, {trademark.ID});";
                cmd.ExecuteNonQuery();
            }
            catch
            {
                shop = null;
            }
            sqlConnection.Close();
            return shop;

        }

        public static Shop GetShop(int id)
        {
            SqlConnection sqlConnection = new SqlConnection(Common.ConnectionString);
            sqlConnection.Open();
            SqlCommand cmd = sqlConnection.CreateCommand();
            Shop shop;
            try
            {
                cmd.CommandText = $"SELECT * FROM Shop WHERE Id = {id};";
                var result = cmd.ExecuteReader();
                result.Read();
                Trademark trademark = DAL.TrademarkController.GetTrademark(int.Parse(result["TrademarkID"].ToString()));
                shop = new Shop(int.Parse(result["Id"].ToString()), trademark, result["Address"].ToString());
            }
            catch
            {
                shop = null;
            }
            sqlConnection.Close();
            return shop;
        }

        public static Shop GetShop(string address)
        {
            SqlConnection sqlConnection = new SqlConnection(Common.ConnectionString);
            sqlConnection.Open();
            SqlCommand cmd = sqlConnection.CreateCommand();
            Shop shop;
            try
            {
                cmd.CommandText = $"SELECT * FROM Shop WHERE Address = {address};";
                var result = cmd.ExecuteReader();
                result.Read();
                Trademark trademark = DAL.TrademarkController.GetTrademark(int.Parse(result["TrademarkID"].ToString()));
                shop = new Shop(int.Parse(result["Id"].ToString()), trademark, result["Address"].ToString());
            }
            catch
            {
                shop = null;
            }
            sqlConnection.Close();
            return shop;
        }

        public static List<Shop> GetAllShops()
        {
            SqlConnection sqlConnection = new SqlConnection(Common.ConnectionString);
            sqlConnection.Open();
            SqlCommand cmd = sqlConnection.CreateCommand();
            List<Shop> list = new List<Shop>();
            try
            {
                cmd.CommandText = $"SELECT * FROM Shop;";
                var result = cmd.ExecuteReader();
                Trademark trademark;
                while (result.Read())
                {
                    trademark = DAL.TrademarkController.GetTrademark(int.Parse(result["TrademarkID"].ToString()));
                    list.Add(new Shop(int.Parse(result["Id"].ToString()), trademark, result["Address"].ToString()));
                }
            }
            catch
            {
                list = null;
            }
            sqlConnection.Close();
            return list;
        }

        public static List<Shop> GetAllShopsByTrademark(Trademark trademark)
        {
            SqlConnection sqlConnection = new SqlConnection(Common.ConnectionString);
            sqlConnection.Open();
            SqlCommand cmd = sqlConnection.CreateCommand();
            List<Shop> list = new List<Shop>();
            try
            {
                cmd.CommandText = $"SELECT * FROM Shop WHERE TrademarkID = {trademark.ID};";
                var result = cmd.ExecuteReader();
                while (result.Read())
                {
                    list.Add(new Shop(int.Parse(result["Id"].ToString()), trademark, result["Address"].ToString()));
                }
            }
            catch
            {
                list = null;
            }
            sqlConnection.Close();
            return list;
        }

        public static bool UpdateShop(Shop shop, string address)
        {
            SqlConnection sqlConnection = new SqlConnection(Common.ConnectionString);
            sqlConnection.Open();
            SqlCommand cmd = sqlConnection.CreateCommand();
            try
            {
                cmd.CommandText = $"UPDATE Shop SET Address = {address}, WHERE Id = {shop}.ID};";
                cmd.ExecuteNonQuery();
                sqlConnection.Close();
                shop.Address = address;
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool DeleteShop(Shop shop)
        {
            SqlConnection sqlConnection = new SqlConnection(Common.ConnectionString);
            sqlConnection.Open();
            SqlCommand cmd = sqlConnection.CreateCommand();
            try
            {
                cmd.CommandText = $"DELETE FROM Shop WHERE Id = {shop.ID};";
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

