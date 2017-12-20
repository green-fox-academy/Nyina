using NUnit.Framework;
using UniqueChars;
using System.Collections.Generic;

namespace UnitTestProject1
{
    [TestFixture]
    public class UnitTest1
    {
        //átneveztük a programban a class-t UniqueChar-ra (nem szabad a namespacenek és a classnak ua-t a nevet adni
        UniqueChar uc = new UniqueChar();

        [Test]
        public void CountDoubleLetters()
        {
            var result = uc.CountChar('a', "alma");
            Assert.AreEqual(2, result);
        }

        [Test]
        public void UniqueLetters()
        {
            var result = uc.UniqueCharacters("fifa");
            List<char> charList = new List<char> { 'i', 'a' };
            Assert.AreEqual(charList, result);
        }

        [Test]
        public void UniqueUpperLetters()
        {
            //az almát nagybetûkkel adjuk be
            var result = uc.UniqueCharacters("alma".ToUpper());
            List<char> charList = new List<char> { 'L', 'M' };
            Assert.AreEqual(charList, result);
        }

    }
}
