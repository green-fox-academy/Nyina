using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise8
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a LINQ Expression to find the uppercase characters in a string!

            string word = "Alma";

            //var uppercaseCharacter = word.Split(' ').Where(s => s.Equals(s.ToUpper());

            //var uppercaseCharacter = word.Where(s => String.Equals(s, s.ToUpper(),StringComparison.Ordinal));

            //var uppercaseCharacter = word.Split(' ').Where(s => String.Equals(s, s.ToUpper(), StringComparison.Ordinal));

            //var uppercaseCharacter = word.ToArray().Where(letter => char.IsLetter(letter) && letter.ToUpper());
            //var uppercaseCharacter = word.ToArray().Where(s => char.Equals(s, s.ToUpper(),
                            //StringComparison.Ordinal));

            //var uppercaseCharacter = word.ToArray().Where(s => word.Contains(s.ToUpper());

            var uppercaseCharacter = word.Where(s => word.Contains(s.ToUpper()));

            Console.WriteLine(uppercaseCharacter);

            Console.ReadLine();

        }
    }
}
