using NUnit.Framework;
using CandyShop;

namespace UnitTestProject1
{
    [TestFixture]
    public class UnitTest1
    {
        Candyshop candyshop = new Candyshop();

        [Test]
        public void Sell()
        {
            public double candyshop.Amount { get; set; } = 1;
            var result = candyshop.Sell(Candyshop.LOLLIPOP, 1);
            Assert.AreEqual(-1, result);
        }
    }
}
