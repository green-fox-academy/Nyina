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
            string[] lines = { "This is now a new information", "This is the second", "This is the last" };
            using (System.IO.StreamWriter writer = new System.IO.StreamWriter("SomeNewText.txt"))
            foreach(var singleLine in lines)
            {
                Console.WriteLine(singleLine);
            }
            Console.ReadLine();
        }
    }
}
