using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Admin : Person
    {
        public Admin() { }

        public Admin(string name, UserRole role, string phoneNumber, string email, string password) : base(name, role, phoneNumber, email, password) { }

        public Admin(int id, string name, UserRole role, string phoneNumber, string email, string password) : base(id, name, role, phoneNumber, email, password) { }

        public bool RegisterShop(Trademark trademark, string address)
        {
            Shop newShop = new Shop(trademark, address);
            return RegisterShop(newShop);
        }

        public bool RegisterShop(Shop shop)
        {
            // зробити тут виклик контролера і передати потрібний об'єкт, щоб він створив його у БД та повернути тру. У випадку проблем фолс
            throw new NotImplementedException();
        }

        public bool RegisterTrademark(string name, string description)
        {
            Trademark newTrademark = new Trademark(name, description);
            return RegisterTrademark(newTrademark);
        }

        public bool RegisterTrademark(Trademark trademark)
        {
            // зробити тут виклик контролера і передати потрібний об'єкт, щоб він створив його у БД та повернути тру. У випадку проблем фолс
            throw new NotImplementedException();
        }

        public bool RegisterShopManager(string name, UserRole role, string phoneNumber, string email, string password, Shop managedShop)
        {
            ShopManager newManager = new ShopManager(name, role, phoneNumber, email, password, managedShop);
            return RegisterShopManager(newManager);
        }

        public bool RegisterShopManager(ShopManager manager)
        {
            // зробити тут виклик контролера і передати потрібний об'єкт, щоб він створив його у БД та повернути тру. У випадку проблем фолс
            throw new NotImplementedException();
        }

        public bool DeleteShop(Shop shop)
        {
            // зробити тут виклик контролера і передати потрібний об'єкт, щоб він видалив його з БД та повернути тру. У випадку проблем фолс.
            throw new NotImplementedException();
        }

        public bool DeleteTrademark(Trademark trademark)
        {
            // зробити тут виклик контролера і передати потрібний об'єкт, щоб він видалив його з БД та повернути тру. У випадку проблем фолс.
            throw new NotImplementedException();
        }

        public bool DeleteShopManager(ShopManager shopManager)
        {
            // зробити тут виклик контролера і передати потрібний об'єкт, щоб він видалив його з БД та повернути тру. У випадку проблем фолс.
            throw new NotImplementedException();
        }

        public bool EditShop(Shop shop, string newTrademark, string newAddress)
        {
            // зробити тут виклик контролера і передати потрібний об'єкт, щоб він оновив його у БД та повернути тру. У випадку проблем фолс.
            throw new NotImplementedException();
        }

        public bool EditTrademark(Trademark trademark, string newName, string newDescription)
        {
            // зробити тут виклик контролера і передати потрібний об'єкт, щоб він оновив його у БД та повернути тру. У випадку проблем фолс.
            throw new NotImplementedException();
        }

        public bool EditShopManafer(ShopManager manager, string newName, string newEmail, string newPhone)
        {
            // зробити тут виклик контролера і передати потрібний об'єкт, щоб він оновив його у БД та повернути тру. У випадку проблем фолс.
            throw new NotImplementedException();
        }

        public bool ResetShopManagersPassword(ShopManager manager, string newPassword)
        {
            manager.ResetPassword(this, newPassword);
            // зробити тут виклик контролера і передати потрібний об'єкт, щоб він оновив його у БД та повернути тру. У випадку проблем фолс.
            throw new NotImplementedException();
        }

        public bool RejectDiscountRequest(DiscountRequest request)
        {
            request.RequestedDiscount.Reject();
            // зробити тут виклик контролера і передати потрібний об'єкт, щоб він оновив його у БД та повернути тру. У випадку проблем фолс.
            throw new NotImplementedException();
        }

        public bool ApproveDiscountRequest(DiscountRequest request)
        {
            request.RequestedDiscount.Approve();
            // зробити тут виклик контролера і передати потрібний об'єкт, щоб він оновив його у БД та повернути тру. У випадку проблем фолс.
            throw new NotImplementedException();
        }
    }
}
