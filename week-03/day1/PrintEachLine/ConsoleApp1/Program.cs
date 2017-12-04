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
            try
            {
                string[] text = File.ReadAllLines("my - file.txt");
                foreach (string line in text)
                {
                    Console.WriteLine(line);
                }
            }

            catch (Exception)
            {
                Console.WriteLine("Unable to read file: my - file.txt");
            }
            Console.ReadLine();


            // Write a program that opens a file called "my-file.txt", then prints
            // each of lines form the file.
            // If the program is unable to read the file (for example it does not exists),
            // then it should print an error message like: "Unable to read file: my-file.txt"

        }
    }
}
