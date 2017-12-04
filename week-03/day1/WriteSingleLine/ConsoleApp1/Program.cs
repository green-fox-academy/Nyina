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
                File.WriteAllText("my-file.txt", "This is a new text");
            }
            catch
            {
                Console.WriteLine("Unable to write file: my-file.txt");
            }
            finally
            {
                Console.WriteLine();
                Console.ReadLine();
            }

            // Open a file called "my-file.txt"
            // Write your name in it as a single line
            // If the program is unable to write the file,
            // then it should print an error message like: "Unable to write file: my-file.txt"

        }
    }
}
