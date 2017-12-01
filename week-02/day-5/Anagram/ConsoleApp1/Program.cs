using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me 2 words!");
            string word1 = Console.ReadLine();
            string word2 = Console.ReadLine();
            Anagram(word1, word2);
            Console.ReadLine();
        }

        static void Anagram(string string1, string string2)
        {

            List<string> stringOne = new List<string>() {string1};
            List<string> stringTwo = new List<string>() {string2};

            int length1 = string1.Length;
            int length2 = string2.Length;
            bool answer = true;
            int character = 0;

            if (length1 == length2)
            {
                for (int i = 0; i < length1; i++){
                    if (stringOne.Remove(stringTwo[i]))
                    {
                        character++;
                    } 
                }
                if (character == string1.Length)
                {
                    answer = true;
                }
                else
                {
                    answer = false;
                }
            }
            Console.WriteLine(answer);
        }
    }

}
