using Domain;

namespace DomainTests
{
    [TestClass]
    public class ShopTests
    {
        Trademark EmptyTrademark = new Trademark();

        [TestMethod]
        public void Valid()
        {
            Shop shop = new Shop(EmptyTrademark, "Any address");
            Assert.IsTrue(shop.IsValid());
        }

        [TestMethod]
        public void Invalid_address()
        {
            Shop shop = new Shop(EmptyTrademark, "Any address");
            shop.Address = "";
            Assert.ThrowsException<ArgumentException>(() => shop.IsValid());
        }

        [TestMethod]
        public void TrademarkIsNull()
        {
            Shop shop = new Shop(EmptyTrademark, "Any address");
            shop.Trademark = null;
            Assert.ThrowsException<ArgumentException>(() => shop.IsValid());
        }
    }
}
