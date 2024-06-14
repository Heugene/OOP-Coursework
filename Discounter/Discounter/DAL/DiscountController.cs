using Domain;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DiscountController
    {
        // Create

        // Get discounts: (end datetime >= now and APPROVED) All (actual), All (actual) by trademark, 1 by ID

        // Get requests: All (where discount not rejected and not approved) (for admin to reject or approve)

        // Update discount name, description

        // Approve and reject methods

        public static Discount CreateDiscount(ShopManager manager, string name, DiscountedItem item, string description, decimal oldPrice, decimal newPrice, DateTime startDateTime, DateTime endDateTime)
        {
            Discount discount = new Discount(name, item, description, oldPrice, newPrice, startDateTime, endDateTime);
            DiscountRequest request = new DiscountRequest(DateTime.Now, manager, discount);

            if (discount.IsValid() && request.IsValid())
            {
                SqlConnection sqlConnection = new SqlConnection(Common.ConnectionString);
                sqlConnection.Open();
                SqlCommand cmd = sqlConnection.CreateCommand();
                try
                {
                    cmd.CommandText = $"SELECT MAX(Id) FROM Discount + 1;";
                    int newDiscountId = (int)cmd.ExecuteScalar();

                    cmd.CommandText = $"INSERT INTO Discount VALUES ({newDiscountId}, '{name}', '{description}', {item.ID}, {oldPrice}, {newPrice}, '{startDateTime}', '{endDateTime}', 0, 0);";
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = $"INSERT INTO DiscountRequest VALUES ({manager.ID}, {discount.ID}, {request.CreatedDateTime}, NULL);";
                    cmd.ExecuteNonQuery();
                }
                catch
                {
                    discount = null;
                    request = null;
                }
                sqlConnection.Close();
            }
            return discount;

        }

        public static List<DiscountRequest> GetUnviewedRequests()
        {
            SqlConnection sqlConnection = new SqlConnection(Common.ConnectionString);
            sqlConnection.Open();
            SqlCommand cmd = sqlConnection.CreateCommand();
            List<DiscountRequest> list = new List<DiscountRequest>();
            try
            {
                cmd.CommandText = $"SELECT * FROM DiscountRequest INNER JOIN Discount ON DiscountRequest.DiscountID = Discount.Id;";
                var result = cmd.ExecuteReader();

                Discount discount;
                ShopManager manager;
                DateTime reviewed;
                while (result.Read())
                {
                    discount = DAL.DiscountController.GetDiscount(int.Parse(result["DiscountID"].ToString()));
                    manager = DAL.ManagerController.GetShopManager(int.Parse(result["ManagerID"].ToString()));
                    if (DateTime.TryParse(result["ViewedDateTime"].ToString(), out reviewed))
                    {
                        list.Add(new DiscountRequest(int.Parse(result["Id"].ToString()), DateTime.Parse(result["CreatedDateTime"].ToString()), manager, discount, reviewed));
                    }
                    else
                    {
                        list.Add(new DiscountRequest(int.Parse(result["Id"].ToString()), DateTime.Parse(result["CreatedDateTime"].ToString()), manager, discount, null));
                    }
                    
                }
                list = list.Where(x => x.ViewedDateTime is null).ToList();
            }
            catch
            {
                list = null;
            }
            sqlConnection.Close();
            return list;
        }

        public static Discount GetDiscount(int id)
        {
            SqlConnection sqlConnection = new SqlConnection(Common.ConnectionString);
            sqlConnection.Open();
            SqlCommand cmd = sqlConnection.CreateCommand();
            Discount discount;
            try
            {
                cmd.CommandText = $"SELECT * FROM Discount WHERE Id = {id};";
                var result = cmd.ExecuteReader();
                result.Read();
                DiscountedItem item = DAL.DiscountedItemController.GetDiscountedItem(int.Parse(result["ItemID"].ToString()));
                discount = new Discount(int.Parse(result["Id"].ToString()), result["Name"].ToString(), item, result["Description"].ToString(), (decimal)result["OldPrice"], (decimal)result["NewPrice"], DateTime.Parse(result["StartDateTime"].ToString()), DateTime.Parse(result["EndDateTime"].ToString()), bool.Parse(result["IsApproved"].ToString()), bool.Parse(result["WasRejected"].ToString()));
            }
            catch
            {
                discount = null;
            }
            sqlConnection.Close();
            return discount;
        }

        public static List<Discount> GetAllActualDiscounts()
        {
            SqlConnection sqlConnection = new SqlConnection(Common.ConnectionString);
            sqlConnection.Open();
            SqlCommand cmd = sqlConnection.CreateCommand();
            List<Discount> list = new List<Discount>();
            try
            {
                cmd.CommandText = $"SELECT * FROM Discount WHERE WasRejected = 0 AND IsApproved = 1 AND EndDateTime >= N'{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}';";
                var result = cmd.ExecuteReader();
                DiscountedItem item;
                while (result.Read())
                {
                    item = DAL.DiscountedItemController.GetDiscountedItem(int.Parse(result["ItemID"].ToString()));
                    list.Add(new Discount(int.Parse(result["Id"].ToString()), result["Name"].ToString(), item, result["Description"].ToString(), (decimal)result["OldPrice"], (decimal)result["NewPrice"], DateTime.Parse(result["StartDateTime"].ToString()), DateTime.Parse(result["EndDateTime"].ToString()), bool.Parse(result["IsApproved"].ToString()), bool.Parse(result["WasRejected"].ToString())));
                }
            }
            catch
            {
                list = null;
            }
            sqlConnection.Close();
            return list;
        }

        public static List<Discount> GetAllActualDiscountsByTrademark(Trademark trademark)
        {
            return GetAllActualDiscounts().Where(x => x.Item.Shop.Trademark.ID == trademark.ID).ToList();
        }

        public static bool UpdateDiscount(Discount discount, string name, string description)
        {
            discount.Name = name;
            discount.Description = description;
            if (discount.IsValid())
            {
                SqlConnection sqlConnection = new SqlConnection(Common.ConnectionString);
                sqlConnection.Open();
                SqlCommand cmd = sqlConnection.CreateCommand();
                try
                {
                    cmd.CommandText = $"UPDATE Discount SET Name = '{name}', Description = '{description}' WHERE Id = {discount.ID};";
                    cmd.ExecuteNonQuery();
                    sqlConnection.Close();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
            return false;
        }

        public static bool ApproveDiscountRequest(DiscountRequest discountRequest)
        {
            SqlConnection sqlConnection = new SqlConnection(Common.ConnectionString);
            sqlConnection.Open();
            SqlCommand cmd = sqlConnection.CreateCommand();
            try
            {
                cmd.CommandText = $"UPDATE Discount SET IsApproved = 1 WHERE Id = {discountRequest.RequestedDiscount.ID};";
                cmd.ExecuteNonQuery();
                cmd.CommandText = $"UPDATE DiscountRequest SET ViewedDateTime = '{DateTime.Now}' WHERE Id = {discountRequest.RequestedDiscount.ID};";
                cmd.ExecuteNonQuery();
                sqlConnection.Close();
                discountRequest.RequestedDiscount.Approve();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool RejectDiscountRequest(DiscountRequest discountRequest)
        {
            SqlConnection sqlConnection = new SqlConnection(Common.ConnectionString);
            sqlConnection.Open();
            SqlCommand cmd = sqlConnection.CreateCommand();
            try
            {
                cmd.CommandText = $"UPDATE Discount SET WasRejected = 1 WHERE Id = {discountRequest.RequestedDiscount.ID};";
                cmd.ExecuteNonQuery();
                cmd.CommandText = $"UPDATE DiscountRequest SET ViewedDateTime = '{DateTime.Now}' WHERE Id = {discountRequest.RequestedDiscount.ID};";
                cmd.ExecuteNonQuery();
                sqlConnection.Close();
                discountRequest.RequestedDiscount.Reject();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static List<Discount> SearchByTrademarkName(List<Discount> discounts, string searchString)
        {
            return discounts.Where(x => x.Item.Shop.Trademark.Name.ToLower().Contains(searchString.ToLower())).ToList();
        }

        public static List<Discount> SearchByItemName(List<Discount> discounts, string searchString)
        {
            return discounts.Where(x => x.Item.Name.ToLower().Contains(searchString.ToLower())).ToList();
        }

        public static List<Discount> SearchByDiscountName(List<Discount> discounts, string searchString)
        {
            return discounts.Where(x => x.Name.ToLower().Contains(searchString.ToLower())).ToList();
        }
    }
}
