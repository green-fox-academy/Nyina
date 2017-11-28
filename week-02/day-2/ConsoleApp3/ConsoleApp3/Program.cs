using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            string am = "kuty";
            appenA(am);

            // - Create a string variable named `am` and assign the value `kuty` to it
            // - Write a function called `appendA` that gets a string as an input
            //   and appends an 'a' character to its end
            // - Print the result of `appendA(am)`
            Console.ReadLine();
        }
        static void appenA(string input)
        {
            Console.WriteLine(input + "a");
        }
    }
}
