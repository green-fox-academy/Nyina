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
            var girls = new List<string> { "Eve", "Ashley", "Bözsi", "Kat", "Jane" };
            var boys = new List<string> { "Joe", "Fred", "Béla", "Todd", "Neef", "Jeff" };
            var order = new List<string>();

            for (int i = 0; i < 5; i++)
            {
                order.Add(girls[i] + boys[i]);
               
            }
            
            foreach (var item in order)
            {
                Console.Write(item);
            }

            // Join the two lists by matching one girl with one boy in the order list
            // Exepected output: "Eve", "Joe", "Ashley", "Fred"...

            Console.ReadLine();
        }
    }
}
