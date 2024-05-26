using Domain;

namespace DomainTests
{
    [TestClass]
    public class ShopManagerTests
    {
        Shop EmptyShop = new Shop();

        [TestMethod]
        public void Valid()
        {
            ShopManager shopManager = new ShopManager("Yar", UserRole.ShopManager, "+380441234567", "aboba@gmail.com", "Aboba123", EmptyShop);
            Assert.IsTrue(shopManager.IsValid());
        }

        [TestMethod]
        public void Invalid_name()
        {
            ShopManager shopManager = new ShopManager("Yar", UserRole.ShopManager, "+380441234567", "aboba@gmail.com", "Aboba123", EmptyShop);
            shopManager.Name = "";
            Assert.ThrowsException<ArgumentException>(() => shopManager.IsValid());
        }

        [TestMethod]
        public void Empty_phone()
        {
            ShopManager shopManager = new ShopManager("Yar", UserRole.ShopManager, "+380441234567", "aboba@gmail.com", "Aboba123", EmptyShop);
            shopManager.PhoneNumber = "";
            Assert.ThrowsException<ArgumentException>(() => shopManager.IsValid());
        }

        [TestMethod]
        public void Invalid_phone()
        {
            ShopManager shopManager = new ShopManager("Yar", UserRole.ShopManager, "+380441234567", "aboba@gmail.com", "Aboba123", EmptyShop);
            shopManager.PhoneNumber = "+kdkksds8892";
            Assert.ThrowsException<ArgumentException>(() => shopManager.IsValid());
        }

        [TestMethod]
        public void Empty_email()
        {
            ShopManager shopManager = new ShopManager("Yar", UserRole.ShopManager, "+380441234567", "aboba@gmail.com", "Aboba123", EmptyShop);
            shopManager.Email = "";
            Assert.ThrowsException<ArgumentException>(() => shopManager.IsValid());
        }

        [TestMethod]
        public void Invalid_email()
        {
            ShopManager shopManager = new ShopManager("Yar", UserRole.ShopManager, "+380441234567", "aboba@gmail.com", "Aboba123", EmptyShop);
            shopManager.PhoneNumber = "sjhdfjsdf@ksjkdj@askdjkas.@jjsk";
            Assert.ThrowsException<ArgumentException>(() => shopManager.IsValid());
        }

        [TestMethod]
        public void Empty_password()
        {
            ShopManager shopManager = new ShopManager("Yar", UserRole.ShopManager, "+380441234567", "aboba@gmail.com", "", EmptyShop);
            Assert.ThrowsException<ArgumentException>(() => shopManager.IsValid());
        }

        [TestMethod]
        public void Invalid_password()
        {
            ShopManager shopManager = new ShopManager("Yar", UserRole.ShopManager, "+380441234567", "aboba@gmail.com", "0000", EmptyShop);
            Assert.ThrowsException<ArgumentException>(() => shopManager.IsValid());
        }

        [TestMethod]
        public void ShopIsNull()
        {
            ShopManager shopManager = new ShopManager("Yar", UserRole.ShopManager, "+380441234567", "aboba@gmail.com", "Aboba123", EmptyShop);
            shopManager.ManagedShop = null;
            Assert.ThrowsException<ArgumentException>(() => shopManager.IsValid());
        }


    }
}
