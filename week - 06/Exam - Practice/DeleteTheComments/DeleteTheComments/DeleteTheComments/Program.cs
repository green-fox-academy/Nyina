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
       

        /* 
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

            for (int i = 0; i < outOfCommentedLines.Count; i++)
            {
                if (outOfCommentedLines[i].Contains("//"))
                {
                    outOfCommentedLines.RemoveAt(i);
                }
            }

            File.WriteAllLines(filename, outOfCommentedLines);
            foreach (var outOfCommentedLine in outOfCommentedLines)
            {
                Console.WriteLine(outOfCommentedLine);
            }
            */
            /*
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
        */
    }
}
