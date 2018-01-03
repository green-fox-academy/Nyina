using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a LINQ Expression to find the strings which starts with A and ends with I in the following array:
            string[] cities = { "ROME", "LONDON", "NAIROBI", "CALIFORNIA", "ZURICH", "NEW DELHI", "AMSTERDAM", "ABU DHABI", "PARIS" };

            var filteredCity = cities.Where(n => n[0] == 'A' && n.Last() == 'I');

            foreach (var element in filteredCity)
            {
                Console.WriteLine(element);
            }

            Console.ReadLine();
        }
    }
}
