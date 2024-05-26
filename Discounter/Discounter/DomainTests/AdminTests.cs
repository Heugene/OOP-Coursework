using Domain;

namespace DomainTests
{
    [TestClass]
    public class AdminTests
    {
        [TestMethod]
        public void Valid()
        {
            Person admin = new Admin("Admin", UserRole.Admin, "+380441234567", "aboba@gmail.com", "Aboba123");
            Assert.IsTrue(admin.IsValid());
        }

        [TestMethod]
        public void Invalid_name()
        {
            Person admin = new Admin("Admin", UserRole.Admin, "+380441234567", "aboba@gmail.com", "Aboba123");
            admin.Name = "";
            Assert.ThrowsException<ArgumentException>(() => admin.IsValid());
        }

        [TestMethod]
        public void Empty_phone()
        {
            Person admin = new Admin("Admin", UserRole.Admin, "+380441234567", "aboba@gmail.com", "Aboba123");
            admin.PhoneNumber = "";
            Assert.ThrowsException<ArgumentException>(() => admin.IsValid());
        }

        [TestMethod]
        public void Invalid_phone()
        {
            Person admin = new Admin("Admin", UserRole.Admin, "+380441234567", "aboba@gmail.com", "Aboba123");
            admin.PhoneNumber = "+kdkksds8892";
            Assert.ThrowsException<ArgumentException>(() => admin.IsValid());
        }

        [TestMethod]
        public void Empty_email()
        {
            Person admin = new Admin("Admin", UserRole.Admin, "+380441234567", "aboba@gmail.com", "Aboba123");
            admin.Email = "";
            Assert.ThrowsException<ArgumentException>(() => admin.IsValid());
        }

        [TestMethod]
        public void Invalid_email()
        {
            Person admin = new Admin("Admin", UserRole.Admin, "+380441234567", "aboba@gmail.com", "Aboba123");
            admin.PhoneNumber = "sjhdfjsdf@ksjkdj@askdjkas.@jjsk";
            Assert.ThrowsException<ArgumentException>(() => admin.IsValid());
        }

        [TestMethod]
        public void Empty_password()
        {
            Person admin = new Admin("Admin", UserRole.Admin, "+380441234567", "aboba@gmail.com", "");
            Assert.ThrowsException<ArgumentException>(() => admin.IsValid());
        }

        [TestMethod]
        public void Invalid_password()
        {
            Person admin = new Admin("Admin", UserRole.Admin, "+380441234567", "aboba@gmail.com", "0000");
            Assert.ThrowsException<ArgumentException>(() => admin.IsValid());
        }
    }
}