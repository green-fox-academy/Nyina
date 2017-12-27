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
        /*
        public static void DeleteComments(string filename)
        {
            string characters = "//";

            string[] lines = File.ReadAllLines(filename);

            foreach (var line in lines)
            {
                if (line.Contains(characters))
                {
                    line.Remove(0, line.Length);
                }
            }
            File.WriteAllLines(filename, lines);
            foreach (var line in lines)
            {
                Console.WriteLine(line);
            }
        }
        */


        public static void DeleteComments(string filename)
        {
            string characters = "//";

            string[] lines = File.ReadAllLines(filename);
            List<string> commentedLines = new List<string>();
            List<string> outOfCommentedLines = new List<string>();

            foreach (var line in lines)
            {
                outOfCommentedLines.Add(line);
            }

            foreach (var outOfCommentedLine in outOfCommentedLines)
            {
                if (outOfCommentedLine.Contains(characters))
                {
                    commentedLines.Add(outOfCommentedLine);
                }
            }

            foreach (var commentedLine in commentedLines)
            {
                outOfCommentedLines.Remove(commentedLine);
            }

        //Tömbbe is át lehet tölteni az outOfCommentedLines, így outOfCommentedLines.ToArray(),
        //de listában hagyva is kiírja
            File.WriteAllLines(filename, outOfCommentedLines.ToArray());
            foreach (var outOfCommentedLine in outOfCommentedLines)
            {
                Console.WriteLine(outOfCommentedLine);
            }
        }

    }
}
