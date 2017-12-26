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

            NumberOfLines("TextFile1.txt");

            // Write a function that takes a filename as string,
            // then returns the number of lines the file contains.
            // It should return zero if it can't open the file, and
            // should not raise any error.
        }
        static void NumberOfLines(string filename)
        {
            string[] array = { };


            try
            {
                array = File.ReadAllLines(filename, Encoding.Default);
            }
            catch
            {
                Console.WriteLine("0");
            }
            finally
            {
                foreach (var file in array)
                {
                    Console.WriteLine(file);
                }

                int lines = array.Length;

                Console.WriteLine(lines);
                Console.ReadLine();
            }
            

        }
    }
}
