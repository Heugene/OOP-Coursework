using Domain;
using System.Drawing;

namespace DomainTests
{
    [TestClass]
    public class DiscountedItemTests
    {
        Bitmap EmptyPicture = new Bitmap(20, 20);
        Shop EmptyShop = new Shop();

        [TestMethod]
        public void Valid()
        {
            DiscountedItem discountedItem = new DiscountedItem("Item", ItemType.Product, "A regular Item", EmptyShop, EmptyPicture);
            Assert.IsTrue(discountedItem.IsValid());
        }

        [TestMethod]
        public void Invalid_name()
        {
            DiscountedItem discountedItem = new DiscountedItem("Item", ItemType.Product, "A regular Item", EmptyShop, EmptyPicture);
            discountedItem.Name = "";
            Assert.ThrowsException<ArgumentException>(() => discountedItem.IsValid());
        }

        [TestMethod]
        public void Invalid_description()
        {
            DiscountedItem discountedItem = new DiscountedItem("Item", ItemType.Product, "A regular Item", EmptyShop, EmptyPicture);
            discountedItem.Description = "";
            Assert.ThrowsException<ArgumentException>(() => discountedItem.IsValid());
        }

        [TestMethod]
        public void PictureIsNull()
        {
            DiscountedItem discountedItem = new DiscountedItem("Item", ItemType.Product, "A regular Item", EmptyShop, EmptyPicture);
            discountedItem.Picture = null;
            Assert.ThrowsException<ArgumentException>(() => discountedItem.IsValid());
        }

        [TestMethod]
        public void ShopIsNull() 
        {
            DiscountedItem discountedItem = new DiscountedItem("Item", ItemType.Product, "A regular Item", EmptyShop, EmptyPicture);
            discountedItem.Shop = null;
            Assert.ThrowsException<ArgumentException>(() => discountedItem.IsValid());
        }
    }
}
