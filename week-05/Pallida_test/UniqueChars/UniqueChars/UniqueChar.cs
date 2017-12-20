using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniqueChars
{
    public class UniqueChar
    {
        static void Main(string[] args)
        {

            // Create a method called `UniqueCharacters` that takes a string as parameter
            // and returns a list with the unique letters of the given string
            // Create basic unit tests for it with at least 3 different test cases
            // Print the characters from that list in the following format:
            // "n", "g", "r", "m"


            //Ezt a static függvények esetén tudjuk konzolon kitesztelni
            //Printer(UniqueCharacters("Almafa"));
            Console.ReadLine();
        }

        //A charListet szeretnénk kiprintelni
        //A static nem kell a teszthez, csak amiatt tettük bele órán, hogy a main-ben elérhessük:
        public void Printer(List<char> c)
        {
            //hogy az utolsó elemet külön tudjuk kezelni
            for (int i = 0; i < c.Count - 1; i++)
            {
                Console.Write("\"" + c[i] + "\"" + ", ");
            }
            //az utolsó elem után nincs vessző, ezért így lekezeljük
            Console.WriteLine("\"" + c[c.Count - 1] + "\"");
        }



        public List<char> UniqueCharacters(string param)
        {
            List<char> charList = new List<char>();

            //A stringet szétbontjuk karakter tömbnek:
            char[] charArray = param.ToCharArray();

            //Az is jó, ha nem foglalunk le neki egy tömböt:
            //param.ToCharArray();

            for (int i = 0; i < charArray.Length; i++)
            {
                //Végigmegyünk a listában és megnézzük, hogy melyik elemek vannak benne csak egyszer
                if (CountChar(charArray[i], param) == 1)
                {
                    //áttöltjük a listába
                    charList.Add(charArray[i]);
                }
            }
            return charList;
        }


        public int CountChar(char c, string param)
        {
            int charCounter = 0;
            char[] charArray = param.ToCharArray();
            for (int i = 0; i < charArray.Length; i++)
            {
                if (c == charArray[i])
                {
                    charCounter++;
                }
            }
            return charCounter;
        }
    }
}
