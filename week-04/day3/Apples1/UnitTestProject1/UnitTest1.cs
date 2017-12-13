using NUnit.Framework;
using Apples1;

namespace UnitTestProject1
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void GetApple()
        {
            Program prog = new Program();
            var result = prog.GetApple();
            Assert.AreEqual("apple", result);
        }
    }
}
