using System;
using System.Collections.Generic;

namespace TransformList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> OriginalList = new List<string>()
            {
                "abc",
                "ijk",
                "xyz"
            };

            foreach (var listItem in TransformList(OriginalList))
            {
                Console.WriteLine(listItem);
            }
            Console.ReadLine();
        }

        public static List<string> TransformList(List<string> stringsList)
        {
            var resultArray = new string[stringsList.Count];
            var transformedList = new List<string>();

            for (int i = 0; i < stringsList.Count; i++)
            {
                for (int j = 0; j < stringsList.Count; j++)
                {
                    resultArray[i] += stringsList[j][i];
                }
                transformedList.Add(resultArray[i]);
            }
            return transformedList;
        }
    }
}
