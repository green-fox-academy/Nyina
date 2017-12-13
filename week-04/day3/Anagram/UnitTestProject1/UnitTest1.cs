using NUnit.Framework;
using Anagramma;


namespace UnitTestProject1
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void CheckLength()
        {
            var anag = new Anagram();
            var result = anag.AnagramMethod("kutya", "macska");
            Assert.AreEqual(false, result);
        }

        [Test]
        public void MultipleLetters()
        {
            var anag = new Anagram();
            var result = anag.AnagramMethod("kutya", "akuty");
            Assert.AreEqual(true, result);
        }
    }
}
