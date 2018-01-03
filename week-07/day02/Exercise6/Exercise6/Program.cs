using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a LINQ Expression to find the frequency of characters in a given string!

            string word = "alma";

            var wordFrequency = word.Select(n => n)
                                .GroupBy(n => n)
                                .ToDictionary(n => n.Key, n => n.Count());

            foreach (var pair in wordFrequency)
            {
                Console.WriteLine("{0}, {1}",
                    pair.Key,
                    pair.Value);
            }

            Console.ReadLine();

        }
    }
}
