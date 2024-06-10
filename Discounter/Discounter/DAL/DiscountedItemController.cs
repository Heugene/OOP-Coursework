using Domain;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DiscountedItemController
    {
        public static DiscountedItem CreateDiscountedItem(string name, ItemType type, string description, Shop shop, Bitmap picture)
        {
            DiscountedItem item = new DiscountedItem(name, type, description, shop, picture);

            if (item.IsValid())
            {
                SqlConnection sqlConnection = new SqlConnection(Common.ConnectionString);
                sqlConnection.Open();
                SqlCommand cmd = sqlConnection.CreateCommand();
                try
                {
                    cmd.CommandText = $"SELECT MAX(Id) FROM DiscountedItem + 1;";
                    int newItemId = (int)cmd.ExecuteScalar();

                    cmd.CommandText = $"INSERT INTO DiscountedItem VALUES ('{newItemId}', '{name}', '{description}', '{type.ToString()}', {shop.ID});";
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = $"INSERT INTO ItemPicture VALUES ({newItemId}, @photo);";

                    MemoryStream ms = new MemoryStream();
                    picture.Save(ms, ImageFormat.Png);
                    byte[] photo_array = new byte[ms.Length];
                    ms.Position = 0;
                    ms.Read(photo_array, 0, photo_array.Length);
                    cmd.Parameters.AddWithValue("@photo", photo_array);

                    cmd.ExecuteNonQuery();
                }
                catch
                {
                    item = null;
                }
                sqlConnection.Close();
            }
            return item;
        }

        public static DiscountedItem GetDiscountedItem(int id)
        {
            SqlConnection sqlConnection = new SqlConnection(Common.ConnectionString);
            sqlConnection.Open();
            SqlCommand cmd = sqlConnection.CreateCommand();
            DiscountedItem item;
            try
            {
                cmd.CommandText = $"SELECT * FROM DiscountedItem WHERE Id = {id};";
                var result = cmd.ExecuteReader();
                result.Read();
                Shop shop = DAL.ShopController.GetShop(int.Parse(result["ShopID"].ToString()));
                item = new DiscountedItem(int.Parse(result["Id"].ToString()), result["Name"].ToString(), Enum.Parse<ItemType>(result["Type"].ToString()), result["Description"].ToString(), shop);

                // ТИМЧАСОВО ВІДКЛЮЧИВ ЗАВАНТАЖЕННЯ КАРТИНКИ. ВИДАЄ ЕКСЕПШЕН, ПОТІМ РОЗБЕРУСЬ.

                //cmd.CommandText = $"SELECT Picture FROM ItemPicture WHERE ItemID = {item.ID}";
                //var imageReader = cmd.ExecuteReader();
                //imageReader.Read();
                //byte[] imageByteArray = (byte[])(imageReader["Picture"]);
                //MemoryStream ms = new MemoryStream(imageByteArray);
                //item.SetPicture(new Bitmap(Image.FromStream(ms)));
            }
            catch
            {
                item = null;
            }
            sqlConnection.Close();
            return item;
        }

        public static List<DiscountedItem> GetAllDiscountedItems()
        {
            SqlConnection sqlConnection = new SqlConnection(Common.ConnectionString);
            sqlConnection.Open();
            SqlCommand cmd = sqlConnection.CreateCommand();
            List<DiscountedItem> list = new List<DiscountedItem>();
            try
            {
                cmd.CommandText = $"SELECT * FROM DiscountedItem;";
                var result = cmd.ExecuteReader();
                while (result.Read())
                {
                    Shop shop = DAL.ShopController.GetShop(int.Parse(result["ShopID"].ToString()));
                    list.Add(new DiscountedItem(int.Parse(result["Id"].ToString()), result["Name"].ToString(), Enum.Parse<ItemType>(result["Type"].ToString()), result["Description"].ToString(), shop));
                }

                //foreach (var item in list)
                //{
                //    cmd.CommandText = $"SELECT Picture FROM ItemPicture WHERE ItemID = {item.ID}";
                //    var imageReader = cmd.ExecuteReader();
                //    imageReader.Read();
                //    byte[] imageByteArray = (byte[])(imageReader["Picture"]);
                //    MemoryStream ms = new MemoryStream(imageByteArray);
                //    item.SetPicture(new Bitmap(Image.FromStream(ms)));
                //}
            }
            catch
            {
                list = null;
            }
            sqlConnection.Close();
            return list;
        }

        public static List<DiscountedItem> GetAllDiscountedItemsByTrademark(Trademark trademark)
        {
            SqlConnection sqlConnection = new SqlConnection(Common.ConnectionString);
            sqlConnection.Open();
            SqlCommand cmd = sqlConnection.CreateCommand();
            List<DiscountedItem> list = new List<DiscountedItem>();
            try
            {
                cmd.CommandText = $"SELECT * FROM DiscountedItem INNER JOIN Shop ON DiscountedItem.ShopID = Shop.Id WHERE Shop.TrademarkID = {trademark.ID};";
                var result = cmd.ExecuteReader();
                while (result.Read())
                {
                    Shop shop = DAL.ShopController.GetShop(int.Parse(result["ShopID"].ToString()));
                    list.Add(new DiscountedItem(int.Parse(result["Id"].ToString()), result["Name"].ToString(), Enum.Parse<ItemType>(result["Type"].ToString()), result["Description"].ToString(), shop));
                }
                result.Close();

                //foreach (var item in list)
                //{
                //    cmd.CommandText = $"SELECT Picture FROM ItemPicture WHERE ItemID = {item.ID}";
                //    var imageReader = cmd.ExecuteReader();
                //    imageReader.Read();
                //    byte[] imageByteArray = (byte[])(imageReader["Picture"]);
                //    MemoryStream ms = new MemoryStream(imageByteArray);
                //    item.SetPicture(new Bitmap(Image.FromStream(ms)));
                //}
            }
            catch
            {
                list = null;
            }
            sqlConnection.Close();
            return list;
        }

        public static bool UpdateDiscountedItem(DiscountedItem item, string name, string description, Bitmap picture)
        {
            item.Name = name;
            item.Description = description;
            item.SetPicture(picture);

            if (item.IsValid())
            {
                SqlConnection sqlConnection = new SqlConnection(Common.ConnectionString);
                sqlConnection.Open();
                SqlCommand cmd = sqlConnection.CreateCommand();
                try
                {
                    cmd.CommandText = $"UPDATE DiscountedItem SET Name = '{name}', Description = '{description}', WHERE Id = {item.ID};";
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = $"UPDATE ItemPicture SET Picture = @photo WHERE ItemID = {item.ID};";

                    MemoryStream ms = new MemoryStream();
                    picture.Save(ms, ImageFormat.Png);
                    byte[] photo_array = new byte[ms.Length];
                    ms.Position = 0;
                    ms.Read(photo_array, 0, photo_array.Length);
                    cmd.Parameters.AddWithValue("@photo", photo_array);

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

        public static bool DeleteDiscountedItem(DiscountedItem item)
        {
            SqlConnection sqlConnection = new SqlConnection(Common.ConnectionString);
            sqlConnection.Open();
            SqlCommand cmd = sqlConnection.CreateCommand();
            try
            {
                cmd.CommandText = $"DELETE FROM DiscountedItem WHERE Id = {item.ID};";
                cmd.ExecuteNonQuery();
                cmd.CommandText = $"DELETE FROM ItemPicture WHERE ItemId = {item.ID};";
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
