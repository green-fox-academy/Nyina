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
            
            string[] DuplText = File.ReadAllLines("duplicated-chars.txt");

            DuplText.Split("\n");

            string[] OkText = RepeatedLetters(DuplText);

            File.WriteAllLines("OkTxt.txt", OkText);

        }

        static string RepeatedLetters(string[] word)
        {
             string[] temp = "";
             
             for (int i = 0; i < word.Length - 1; i++)
             {
                
                 if (word[i] == word[i + 1])
                 {
                    temp = word[i + 1];
                 }
             }
             return(word);
           
        }

    }
}
