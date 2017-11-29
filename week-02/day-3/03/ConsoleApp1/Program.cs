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
            string quote = "Hofstadter's Law: It you expect, even when you take into account Hofstadter's Law.";
            string quote1 = "Hofstadter's Law: It ";
            string quote2 = "always takes longer than";
            string quote3 = "you expect, even when you take into account Hofstadter's Law.";


           StringBuilder result = new StringBuilder(quote);
           result.Insert(21, quote2);

            // B megoldás: string result = quote1 + quote2 + quote3;

            //quote.Substring "always takes longer than"
            Console.WriteLine(result);

            // When saving this quote a disk error has occured. Please fix it.
            // Add "always takes longer than" to the StringBuilder (quote) between the words "It" and "you"
            // Using pieces of the quote variable (instead of just redefining the string)
            
            Console.ReadLine();
        }
    }
}
