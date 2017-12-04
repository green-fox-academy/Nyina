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
            CopyFile("NewFile.txt");

            // Write a function that reads all lines of a file and writes the read lines to an other file (a.k.a copies the file)
            // It should take the filenames as parameters
            // It should return a boolean that shows if the copy was successful
        }

        static void CopyFile(string filename)
        {
            //Console.WriteLine("Give me a path");
            //filename = Console.ReadLine();
            bool crash = false;
            bool success = true;

            string[] lines = File.ReadAllLines(filename);
            try
            {
                foreach (var line in lines)
                {
                    Console.WriteLine(line);
                }
                string[] lines = { "This is now a new information", "This is the second", "This is the last" };
                StreamWriter sw = new StreamWriter("NewFile", true);
                sw.WriteLine(line1);
                sw.Close();
            }
            catch (Exception)
            {
                Console.WriteLine(crash);
            }

            finally
            {
                Console.WriteLine(success);
                Console.ReadLine();
            }


        }

    }
}
