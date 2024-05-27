using Domain;

namespace DomainTests
{
    [TestClass]
    public class DiscountTests
    {
        DiscountedItem EmptyItem = new DiscountedItem();
        static DateTime Start = DateTime.Now + TimeSpan.FromDays(1);
        static DateTime End = Start + TimeSpan.FromDays(1);

        [TestMethod]
        public void Valid()
        {
            Discount discount = new Discount("Discount", EmptyItem, "WOW MEGA SALEEEEE", 60.99m, 29.99m, Start, End);
            Assert.IsTrue(discount.IsValid());
        }

        [TestMethod]
        public void Invalid_name()
        {
            Discount discount = new Discount("Discount", EmptyItem, "WOW MEGA SALEEEEE", 60.99m, 29.99m, Start, End);
            discount.Name = "";
            Assert.ThrowsException<ArgumentException>(() => discount.IsValid());
        }


        [TestMethod]
        public void ItemIsNull()
        {
            Discount discount = new Discount("Discount", EmptyItem, "WOW MEGA SALEEEEE", 60.99m, 29.99m, Start, End);
            discount.Item = null;
            Assert.ThrowsException<ArgumentException>(() => discount.IsValid());
        }

        [TestMethod]
        public void Invalid_description()
        {
            Discount discount = new Discount("Discount", EmptyItem, "WOW MEGA SALEEEEE", 60.99m, 29.99m, Start, End);
            discount.Description = "";
            Assert.ThrowsException<ArgumentException>(() => discount.IsValid());
        }

        [TestMethod]
        public void OldPriceBelowOrZero()
        {
            Discount discount = new Discount("Discount", EmptyItem, "WOW MEGA SALEEEEE", 60.99m, 29.99m, Start, End);
            discount.OldPrice = -1;
            Assert.ThrowsException<ArgumentException>(() => discount.IsValid());
        }

        [TestMethod]
        public void NewPriceBelowZero()
        {
            Discount discount = new Discount("Discount", EmptyItem, "WOW MEGA SALEEEEE", 60.99m, 29.99m, Start, End);
            discount.NewPrice = -1;
            Assert.ThrowsException<ArgumentException>(() => discount.IsValid());
        }

        [TestMethod]
        public void NewPriceHigherOrEqualToOldPrice()
        {
            Discount discount = new Discount("Discount", EmptyItem, "WOW MEGA SALEEEEE", 60.99m, 29.99m, Start, End);
            discount.NewPrice = 70;
            Assert.ThrowsException<ArgumentException>(() => discount.IsValid());
        }

        [TestMethod]
        public void StartIsNull()
        {
            Discount discount = new Discount("Discount", EmptyItem, "WOW MEGA SALEEEEE", 60.99m, 29.99m, Start, End);
            discount.StartDateTime = null;
            Assert.ThrowsException<ArgumentException>(() => discount.IsValid());
        }

        [TestMethod]
        public void EndIsNull() 
        {
            Discount discount = new Discount("Discount", EmptyItem, "WOW MEGA SALEEEEE", 60.99m, 29.99m, Start, End);
            discount.EndDateTime = null;
            Assert.ThrowsException<ArgumentException>(() => discount.IsValid());
        }

        [TestMethod]
        public void StartInThePast()
        {
            Discount discount = new Discount("Discount", EmptyItem, "WOW MEGA SALEEEEE", 60.99m, 29.99m, Start, End);
            discount.StartDateTime = new DateTime(2012, 11, 9);
            Assert.ThrowsException<ArgumentException>(() => discount.IsValid());
        }

        [TestMethod]
        public void EndBeforeStart()
        {
            Discount discount = new Discount("Discount", EmptyItem, "WOW MEGA SALEEEEE", 60.99m, 29.99m, Start, End);
            discount.EndDateTime = new DateTime(2002, 2, 6);
            Assert.ThrowsException<ArgumentException>(() => discount.IsValid());
        }
    }
}