using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class ShopManager : Person
    {
        public Shop? ManagedShop { get; set; }

        public ShopManager() { }

        public ShopManager(string name, UserRole role, string phoneNumber, string email, string password) : base(name, role, phoneNumber, email, password) { }

        public ShopManager(int id, string name, UserRole role, string phoneNumber, string email, string password) : base(id, name, role, phoneNumber, email, password) { }

        public ShopManager(string name, UserRole role, string phoneNumber, string email, string password, Shop managedShop) : this(name, role, phoneNumber, email, password) 
        {
            ManagedShop = managedShop;
        }

        public ShopManager(int id, string name, UserRole role, string phoneNumber, string email, string password, Shop managedShop) : base(id, name, role, phoneNumber, email, password) 
        {
            ManagedShop = managedShop;
        }


    public bool AddDiscountedItem(DiscountedItem discountedItem)
        {
            // зробити тут виклик контролера і передати потрібний об'єкт, щоб він створив його у БД та повернути тру. У випадку проблем фолс
            throw new NotImplementedException();
        }

        public bool CreateDiscount(Discount discount) 
        {
            // зробити тут виклик контролера і передати потрібний об'єкт, щоб він створив його у БД та повернути тру. У випадку проблем фолс
            throw new NotImplementedException();
        }

        public bool CreateDiscountRequest(Discount discount)
        {
            // зробити тут виклик контролера і передати потрібний об'єкт, щоб він створив його у БД та повернути тру. У випадку проблем фолс
            DiscountRequest request = new DiscountRequest(DateTime.UtcNow, this, discount);
            throw new NotImplementedException();
        }

        public bool ResetPassword(Admin sender, string newPassword)
        {
            // тут можна додати перевірку на те, чи існує в базі переданий у якості об'єкту адмін, перш ніж дозволяти змінити комусь пароль, але це задача майбутнього
            bool validAdmin = true;
            if (validAdmin)
            {
                Password = newPassword;
                // зробити тут виклик контролера і передати потрібний об'єкт, щоб він оновив його у БД та повернути тру. У випадку проблем фолс
            }
            throw new NotImplementedException();
        }

        public override bool IsValid()
        {
            base.IsValid();
            if (ManagedShop is null)
            {
                throw new ArgumentException("Managed shop can`t be null");
            }
            return true;
        }
    }
}
