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
            Parameter();

            // Create a function that takes 3 parameters: a path, a word and a number,
            // than it should write to a file.
            // The path parameter should be a string, that describes the location of the file.
            // The word parameter should be a string, that will be written to the file as lines
            // The number paramter should describe how many lines the file should have.
            // So if the word is "apple" and the number is 5, than it should write 5 lines
            // to the file and each line should be "apple"
            // The function should not raise any error if it could not write the file.
        }
        static void Parameter()
        {

            //string path, string word, int number
            string path = "";

                Console.WriteLine("Give me a path a Text and a Row number");
                string input = Console.ReadLine();
                string[] inputA = input.Split(',');

            try
            {
                path = inputA[0];
            }

            catch (Exception)
            {
                Console.WriteLine("Doh, something is missing!");
            }

            finally
            {
            string word = inputA[1];
            int number = Convert.ToInt32(inputA[2]);

            StreamWriter sw = new StreamWriter(path, true);
            string writeArray = word;

            for (int i = 1; i <= number; i++)
            {
                sw.WriteLine(writeArray);
            }
            //sw.WriteLine(writeArray);
            sw.Close();
            Console.ReadLine();
            }

               
        }
    }
}
