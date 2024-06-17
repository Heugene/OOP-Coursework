using Domain;

namespace DomainTests
{
    [TestClass]
    public class DiscountRequestTests
    {
        ShopManager EmptyManager = new ShopManager();
        Discount EmptyDiscount = new Discount();

        [TestMethod]
        public void Valid()
        {
            DiscountRequest request = new DiscountRequest(DateTime.Now, EmptyManager, EmptyDiscount);
            Assert.IsTrue(request.IsValid());
        }

        [TestMethod]
        public void ManagerIsNull()
        {
            DiscountRequest request = new DiscountRequest(DateTime.Now, EmptyManager, EmptyDiscount);
            request.Manager = null;
            Assert.ThrowsException<ArgumentException>(() => request.IsValid());
        }

        public void DiscountIsNull()
        {
            DiscountRequest request = new DiscountRequest(DateTime.Now, EmptyManager, EmptyDiscount);
            request.RequestedDiscount = null;
            Assert.ThrowsException<ArgumentException>(() => request.IsValid());
        }
    }
}
