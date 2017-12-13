using NUnit.Framework;
using Sum;
using System.Collections.Generic;

namespace UnitTestProject1
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void Sum()
        {
            //objektumot példányosítjuk
            Numbers n = new Numbers();
            var result = n.SumMethod(new List<int>{ 6, 7, 8 });
            Assert.AreEqual(21, result);

        }
    }
}
