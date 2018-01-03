using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a LINQ Expression to find the frequency of numbers in the following array:
            int[] n = new int[] { 5, 9, 1, 2, 3, 7, 5, 6, 7, 3, 7, 6, 8, 5, 4, 9, 6, 2 };

            var frequencyOfNumbers = n.Select(x => x)
                                     .OrderByDescending(x => x)
                                     .GroupBy(k => k)
                                     .ToDictionary(x => x.Key, x => x.Count());


            foreach (int number in frequencyOfNumbers.Keys)
            {
                Console.WriteLine("{0}:{1}", number, frequencyOfNumbers[number]);
            }



            Console.ReadLine();

        }
    }
}
