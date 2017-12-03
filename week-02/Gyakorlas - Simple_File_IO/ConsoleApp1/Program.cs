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
            //string text = System.IO.File.ReadAllText("Hello.txt");
            //System.Console.WriteLine(text);
            // Console.ReadLine();

            string[] lines = System.IO.File.ReadAllLines("Hello.txt");

            foreach (var line in lines)
            {
               Console.WriteLine(line);
            }
            Console.ReadLine();

        }
    }
}
