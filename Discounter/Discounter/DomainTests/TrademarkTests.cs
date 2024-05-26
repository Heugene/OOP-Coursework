using Domain;

namespace DomainTests
{
    [TestClass]
    public class TrademarkTests
    {
        [TestMethod]
        public void Valid()
        {
            Trademark trademark = new Trademark("AbobaINC", "AAAAAAAAAAAAA");
            Assert.IsTrue(trademark.IsValid());
        }

        [TestMethod]
        public void Invalid_name() 
        {
            Trademark trademark = new Trademark("AbobaINC", "AAAAAAAAAAAAA");
            trademark.Name = "";
            Assert.ThrowsException<ArgumentException>(() => trademark.IsValid());
        }
    }
}
