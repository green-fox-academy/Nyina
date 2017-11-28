using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int ak = 123;
            
            Console.WriteLine(doubling(ak));
          
            // - Create an integer variable named `ak` and assign the value `123` to it
            // - Create a function called `doubling` that doubles it's input parameter
            // - Print the result of `doubling(ak)`
            Console.ReadLine();
        }
        public static int doubling(int num1)
        {
            return (num1 * 2);
        }
    }
}
