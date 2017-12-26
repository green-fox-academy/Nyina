using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MutualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a method that takes two integer lists as a parameter
            // and returns an integer list with the mutual elements from the lists.
            // Write at least 3 different test cases.

            // For example:
            var firstList = new List<int>() { 1, 1, 2, 3, 3, 4 };
            var secondList = new List<int>() { 3, 4, 4, 5, 6 };

            //var mutualElements = FilterMutualElements(firstList, secondList);

            foreach (var mutualListElement in FilterMutualElements(firstList, secondList))
            {
                Console.WriteLine(mutualListElement);
            }

            /*
            mutualElements.ForEach(i => Console.Write("{0}, ", i));
            // Should print: 
            // [3,4]
            */

            Console.ReadLine();
        }

        public static List<int> FilterMutualElements(List<int> firstList, List<int> secondList)
        {
            List<int> mutualList = new List<int>();
            int counter = 0;

            for (int i = 0; i < secondList.Count; i++)
            {
                if (firstList.Contains(secondList[i]) && !mutualList.Contains(secondList[i]))
                {
                    mutualList.Add(secondList[i]);
                    counter++;
                }
            }

            return mutualList;
        }

    }
}
