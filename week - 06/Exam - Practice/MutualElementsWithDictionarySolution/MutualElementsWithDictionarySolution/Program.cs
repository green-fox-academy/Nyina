using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MutualElementsWithDictionarySolution
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstList = new List<int>() { 1, 1, 2, 3, 3, 4 };
            var secondList = new List<int>() { 3, 4, 4, 5, 6 };

            foreach (var element in GetCommonElements(firstList, secondList))
            {
                Console.WriteLine(element);
            }
            Console.ReadLine();
        }

        public static List<int> GetCommonElements(List<int> firstlist, List<int> secondlist)
        {
            List<int> commonElementList = new List<int>();
            var dictionary = new Dictionary<int, int>();

            foreach (var element in firstlist)
            {
                if (secondlist.Contains(element))
                {
                    if (!dictionary.ContainsKey(element))
                    {
                        dictionary.Add(element, 1);
                    }
                }
            }

            foreach (KeyValuePair<int, int> pair in dictionary)
            {
                commonElementList.Add(pair.Key);
            }
            return commonElementList;
        }
    }
}
