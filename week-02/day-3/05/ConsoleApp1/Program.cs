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
            string reversed = ".eslaf eb t'ndluow ecnetnes siht ,dehctiws erew eslaf dna eurt fo sgninaem eht fI";
            char[] inputreversed = reversed.ToCharArray();
            Array.Reverse(inputreversed);
            string output = new string(inputreversed);

            // Create a function that can reverse a String, which is passed as the parameter
            // Use it on this reversed string to check it!

            Console.WriteLine(output);
            Console.ReadLine();
        }
    }
}
