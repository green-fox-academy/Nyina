using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = File.ReadAllLines("ReversedLines.txt");

            File.WriteAllLines("OK.txt", input);

            Console.ReadLine();

            // Create a method that decrypts reversed-lines.txt
        }
        public static string ReversedLines(string[] text)
        {
            int forward = 0;
            for (int i = text.Length - 1; i >= 0; i--)
            {
                text[forward++] = text[i];
            }
            return(text);
        }
    }
}
