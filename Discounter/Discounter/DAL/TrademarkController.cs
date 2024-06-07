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
    internal class TrademarkController
    {
        public static Trademark CreateTrademark(string name, string description)
        {
            Trademark trademark = new Trademark(name, description);
            SqlConnection sqlConnection = new SqlConnection(Common.ConnectionString);
            sqlConnection.Open();
            SqlCommand cmd = sqlConnection.CreateCommand();
            try
            {
                cmd.CommandText = $"INSERT INTO Trademark VALUES ('{name}', '{description}');";
                cmd.ExecuteNonQuery();
            }
            catch
            {
                trademark = null;
            }
            sqlConnection.Close();
            return trademark;
        }


        public static Trademark GetTrademark(int id)
        {
            SqlConnection sqlConnection = new SqlConnection(Common.ConnectionString);
            sqlConnection.Open();
            SqlCommand cmd = sqlConnection.CreateCommand();
            Trademark trademark;
            try
            {
                cmd.CommandText = $"SELECT * FROM Trademark WHERE Id = {id};";
                var result = cmd.ExecuteReader();
                result.Read();
                trademark = new Trademark(int.Parse(result["Id"].ToString()), result["Name"].ToString(), result["Description"].ToString());
            }
            catch
            {
                trademark = null;
            }
            sqlConnection.Close();
            return trademark;
        }

        public static Trademark GetTrademark(string name)
        {
            SqlConnection sqlConnection = new SqlConnection(Common.ConnectionString);
            sqlConnection.Open();
            SqlCommand cmd = sqlConnection.CreateCommand();
            Trademark trademark;
            try
            {
                cmd.CommandText = $"SELECT * FROM Trademark WHERE Name = {name};";
                var result = cmd.ExecuteReader();
                result.Read();
                trademark = new Trademark(int.Parse(result["Id"].ToString()), result["Name"].ToString(), result["Description"].ToString());
            }
            catch
            {
                trademark = null;
            }
            sqlConnection.Close();
            return trademark;
        }

        public static List<Trademark> GetTrademarks() 
        {
            SqlConnection sqlConnection = new SqlConnection(Common.ConnectionString);
            sqlConnection.Open();
            SqlCommand cmd = sqlConnection.CreateCommand();
            List<Trademark> list = new List<Trademark>();
            try
            {
                cmd.CommandText = $"SELECT * FROM Trademark;";
                var result = cmd.ExecuteReader();
                while(result.Read()) 
                {
                    list.Add(new Trademark(int.Parse(result["Id"].ToString()), result["Name"].ToString(), result["Description"].ToString()));
                }
            }
            catch
            {
                list = null;
            }
            sqlConnection.Close();
            return list;
        }

        public static bool UpdateTrademark(Trademark trademark, string name, string description)
        {
            SqlConnection sqlConnection = new SqlConnection(Common.ConnectionString);
            sqlConnection.Open();
            SqlCommand cmd = sqlConnection.CreateCommand();
            try
            {
                cmd.CommandText = $"UPDATE Trademark SET Name = {name}, Description = {description} WHERE Id = {trademark.ID};";
                cmd.ExecuteNonQuery();
                sqlConnection.Close();
                trademark.Name = name;
                trademark.Description = description;
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool DeleteTrademark(Trademark trademark) 
        {
            SqlConnection sqlConnection = new SqlConnection(Common.ConnectionString);
            sqlConnection.Open();
            SqlCommand cmd = sqlConnection.CreateCommand();
            try
            {
                cmd.CommandText = $"DELETE FROM Trademark WHERE Id = {trademark.ID};";
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
