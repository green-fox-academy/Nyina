using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me some numbers!");
            
            Printer("first", "second", "third");

            // - Create a function called `printer`
            //   which prints the input String parameters
            // - It can have any number of parameters

            // Examples
            // printer("first")
            // printer("first", "second")
            // printer("first", "second", "third", "fourh")
            // ...

            Console.ReadLine();
        }
        static void Printer(params string[] array)
        {
            for (int i = 0; i < array.Length; i++)
               {
                  Console.WriteLine(array[i] + ",");
               }
       
        }
    }
}
