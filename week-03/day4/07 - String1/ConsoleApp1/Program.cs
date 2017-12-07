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
            Console.WriteLine(changeY("xellow"));
            Console.ReadLine();

            // Given a string, compute recursively (no loops) a new string where all the
            // lowercase 'x' chars have been changed to 'y' chars.
        }

        public static string changeY(string text)
        {
            int n = text.Length;


            if (text.LastIndexOf("x") == -1)
            {
                return text;
            }
            else
            {

                return changeY(text.Substring(text.Length - 1)) +" y";

            }
        }
    }
}

