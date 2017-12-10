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
        public List<string> ReversedLines(string[] text)
        {
            List<string> reversedResult = new List<string>();

            var builder = new StringBuilder();
            int forward = 0;


            foreach (var lines in text)
            {
                for (int i = lines.Length - 1; i >= 0; i--)
                {
                    lines[forward++] = lines[i];
                    builder.Append(lines);
                }
                string result = builder.ToString();
                reversedResult.Add(result);
            }
            return (reversedResult);
        }
    }
}
