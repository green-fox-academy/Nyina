// The 100worst.csv file contains the 100 worst singles over 25 years.
// Your task is to check which year produced the most.
// So create the necessary method(s).
// And print out the sentence below with the proper year.
//  `The year when the most worst songs came out is <year>.`

using System;
using System.Collections.Generic;
using System.IO;

namespace WorstSong
{
    public class WorstSong
    {
        public static void Main(string[] args)
        {
            Dictionary<string, int> worstSongs = getSongDictionary(fileReader());

            foreach (KeyValuePair<string, int> pair in worstSongs)
            {
                Console.WriteLine("{0}, {1} ", pair.Key, pair.Value);
            }
            
            Console.ReadLine();
        }

        public static string[] fileReader (string filename)
        {
            string[] lines = File.ReadAllLines(filename);
            return lines;
        }

        public static Dictionary<string, int> getSongDictionary(string[] lines)
        {
            var songsDictionary = new Dictionary<string, int>();

            string[][] splitedLines = new string[lines.Length][];

            for (int i = 0; i < lines.Length; i++)
            {
                splitedLines[i] = lines[i].Split(';');
            }

            int counter = 0;

            foreach (var line in splitedLines)
            {
                for (int i = 0; i < lines.Length; i++)
                {
                    if (!songsDictionary.ContainsKey(line[line.Length]))
                    {
                        songsDictionary.Add(line[line.Length], 1);
                    }
                    else
                    {
                        songsDictionary.Add(line[line.Length], counter++);
                    }
                }
                return songsDictionary;
            }
        }
    }
}




