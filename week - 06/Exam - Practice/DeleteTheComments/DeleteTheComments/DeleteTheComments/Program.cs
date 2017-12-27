using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DeleteTheComments
{
    class Program
    {
        static void Main(string[] args)
        {
            //DeleteComments("Comments.cs");

            DeleteComments("Comments.cs");

            Console.ReadLine();

        }
        
        public static void DeleteComments(string filename)
        {
            string characters = "//";

            string[] lines = File.ReadAllLines(filename);
            List<string> linesList = new List<string>(lines);

            for (int i = 0; i < linesList.Count; i++)
            {
                if (linesList[i].Contains(characters))
                {
                    linesList.RemoveAt(i);
                }
            }

            string[] linesArray = linesList.ToArray();
            File.WriteAllLines(filename, linesArray);
            foreach (var arrayElements in linesArray)
            {
                Console.WriteLine(arrayElements);
            }
        }
    }
}
