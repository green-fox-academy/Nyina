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
            DeleteComments("Comments.cs");

            Console.ReadLine();

        }

        public static void DeleteComments(string filename)
        {
            string characters = "//";

            string[] lines = File.ReadAllLines(filename);
            List<string> linesList = new List<string>(lines);
            List<string> commentedLines = new List<string>(lines);

            foreach (var line in lines)
            {
                linesList.Add(line);
            }

            foreach (var linesListElement in linesList)
            {
                if (linesListElement.Contains(characters))
                {
                    commentedLines.Add(linesListElement);
                }
            }

            foreach (var commentedLine in commentedLines)
            {
                linesList.Remove(commentedLine);
            }

            //Tömbbe is át lehet tölteni az outOfCommentedLines, így outOfCommentedLines.ToArray(),
            //de listában hagyva is kiírja
            File.WriteAllLines(filename, linesList.ToArray());
            foreach (var linesListElement in linesList)
            {
                Console.WriteLine(linesListElement);
            }

        }
    }
}
