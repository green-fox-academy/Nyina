using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anagramma
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Give me 2 words!");
            string word1 = Console.ReadLine();
            string word2 = Console.ReadLine();
            AnagramMethod(word1, word2);
            Console.ReadLine();
        }

    }

}