using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MutualElementsWithDictionary
{
    class Program
    {
        static void Main(string[] args)
        {

            var firstList = new List<int>() { 1, 1, 2, 3, 3, 4 };
            var secondList = new List<int>() { 3, 4, 4, 5, 6 };

            foreach(var element in GetCommonElements(firstList, secondList))
            {
                Console.WriteLine(element);
            }
            Console.ReadLine();
        }

        public static List<int> GetCommonElements(List<int> firstlist, List<int> secondlist)
        {
            List<int> oneList = new List<int>();
            List<int> commonElementList = new List<int>();
            foreach (var element in firstlist)
            {
                oneList.Add(element);
            }
            foreach (var element in secondlist)
            {
                oneList.Add(element);
            }
            var dictionary = new Dictionary<int, int>();

            foreach (var element in oneList)
            {
                //Mivel számok az elementek, a oneListet indexelik, így: 1,2,3 lesz az eredmény
                //if (element == oneList[element])
                //ezzel minden elemből egyet pakol be
                if (oneList.Contains(element))
                {
                    if (!dictionary.ContainsKey(element))
                    {
                        dictionary.Add(element, 1);
                    }
                }
            }
            foreach (KeyValuePair < int, int > pair in dictionary)
            {
                commonElementList.Add(pair.Key);
            }
            return commonElementList;
        }
    }
}
