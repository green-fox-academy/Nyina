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
            Console.WriteLine("Give me a path");
            string filename = Console.ReadLine();
            Console.WriteLine(CopyFile(filename, "NewFile.txt"));
            Console.ReadLine();
        }

        static bool CopyFile(string filename, string goalFile)
        {
            string[] lines = File.ReadAllLines(filename);
            foreach (var line in lines)
            {
                Console.WriteLine(line);
            }

            File.WriteAllLines(goalFile, lines);
            foreach (var singleLine in lines)
            {
                Console.WriteLine(singleLine);
            }
            return true;
        }

    }
}
