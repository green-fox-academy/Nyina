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
            string[] lines = File.ReadAllLines(filename);
            List<string> outOfCommentedLines = new List<string>();

            foreach (var line in lines)
            {
                outOfCommentedLines.Add(line);
            }

            for (int i = 0; i < outOfCommentedLines.Count; i++)
            {
                if (outOfCommentedLines[i].Contains("//"))
                {
                    outOfCommentedLines.RemoveAt(i);
                }
            }

            string[] outOfCommentedLinesArray = outOfCommentedLines.ToArray();
            foreach (var outOfCommentedLine in outOfCommentedLines)
            {
                Console.WriteLine(outOfCommentedLine);
            }
        }
    }
}