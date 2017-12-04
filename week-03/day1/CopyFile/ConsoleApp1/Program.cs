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
            CopyFile("TextFile1.txt", "NewFile.txt");

            // Write a function that reads all lines of a file and writes the read lines to an other file (a.k.a copies the file)
            // It should take the filenames as parameters
            // It should return a boolean that shows if the copy was successful
        }

        static bool CopyFile(string filename, string goalFile)
        {
            //Console.WriteLine("Give me a path");
            //filename = Console.ReadLine();

                string[] lines = File.ReadAllLines(filename);
                File.WriteAllLines(goalFile, lines);
                Console.ReadLine();
                return true;

                /*Console.ReadLine();
                return false;*/

        }

    }
}
