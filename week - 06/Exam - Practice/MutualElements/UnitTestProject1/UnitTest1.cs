using NUnit.Framework;
using MutualElements;
using System.Collections.Generic;

namespace UnitTestProject1
{
    [TestFixture]
    public class UnitTest1
    {
        //Program program = new Program();

        [Test]
        public void UniqueCharacterList()
        {
            List<int> firstList = new List<int> { 1, 1, 2, 3, 3, 4 };
            List<int> secondList = new List<int>() { 3, 4, 4, 5, 6 };
            List<int> commonElementsList = new List<int> { 3, 4 };

            //Ha nem lenne static a method, akkor példányosítani kell az osztályt, 
            //egyébként így lehet elérni a methodot:
            var result = Program.FilterMutualElements(firstList, secondList);

            Assert.AreEqual(commonElementsList, result);
        }

        [Test]
        public void UniqueCharactersFromSameLists()
        {
            List<int> firstList = new List<int> { 1, 1, 2, 3, 3, 4 };
            List<int> secondList = new List<int>() { 1, 1, 2, 3, 3, 4 };
            List<int> commonElementsList = new List<int> { 1, 2, 3, 4 };
            var result = Program.FilterMutualElements(firstList, secondList);

            Assert.AreEqual(commonElementsList, result);
        }

        [Test]
        public void UniqueCharactersIfThereAreNoCommonElements()
        {
            List<int> firstList = new List<int> { 1, 1, 2, 3, 3, 4 };
            List<int> secondList = new List<int>() { 5, 6, 7 };
            List<int> commonElementsList = new List<int> { };
            var result = Program.FilterMutualElements(firstList, secondList);

            Assert.AreEqual(commonElementsList, result);
        }


    }
}
