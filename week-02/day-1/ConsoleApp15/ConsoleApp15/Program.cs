using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Write some kilometers!");
            double kilometers = Convert.ToDouble(Console.ReadLine());

            double miles = kilometers / 1.61;
            Console.WriteLine(miles);
            Console.ReadLine();

            // Write a program that asks for an integer that is a distance in kilometers,
            // then it converts that value to miles and prints it
        }
    }
}
