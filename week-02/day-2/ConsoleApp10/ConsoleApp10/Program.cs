using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] charsToTrim = { '*', ' ', '\'' };
            string banner = "*** Much Ado About Nothing ***";
            string result = banner.Trim(charsToTrim);
            Console.WriteLine("Trimmmed\n   {0}\nto\n   '{1}'", banner, result);
            Console.ReadLine();
        }
       
        
    }
}
