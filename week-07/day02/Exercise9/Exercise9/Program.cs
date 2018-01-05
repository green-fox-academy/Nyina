using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise9
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a LINQ Expression to convert a char array to a string!

            char[] charArray = { 's', 'a', 'm' };

            var charToString = String.Join(",",word).ToString();

            Console.WriteLine(charToString);

            Console.ReadLine();
        }
    }
}
