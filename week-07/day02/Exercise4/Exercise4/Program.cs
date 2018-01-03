using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a LINQ Expression to find which number squared value is more then 20 from the following array:
            int[] n = new[] { 3, 9, 2, 8, 6, 5 };

            //var highSquaredNumber = n.Where(num => Math.Pow(num, 2) > 20).ToList();

            var highSquaredNumber = n.Where(num => Math.Pow(num, 2) > 20).Select(x => Math.Pow(x, 2)).ToList();

            highSquaredNumber.ForEach(i => Console.WriteLine($"[{i}]"));

            Console.ReadLine();
        }
    }
}
