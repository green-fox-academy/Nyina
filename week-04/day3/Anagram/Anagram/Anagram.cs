using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anagramma
{
    public class Anagram
    {

        public string AnagramMethod(string string1, string string2)
        {

            int length1 = string1.Length;
            int length2 = string2.Length;

            char[] string1Array = string1.ToCharArray();
            char[] string2Array = string2.ToCharArray();

            Array.Sort(string1Array);
            Array.Sort(string2Array);

            string sortedString1 = string.Join("", string1Array);
            string sortedString2 = string.Join("", string2Array);

            string answer = "true";
            /* Ez sem és az alatta levő sem kezeli azt az esetet, hogy egy betű az egyszer forduljon elő:*/

            if (length1 == length2)
            {

                if (String.Equals(sortedString1, sortedString2))
                {
                    answer = "true";
                }
                else
                {
                    answer = "false";
                }
            }


            if (length1 == length2)
            {
                for (int i = 0; i < length1; i++)
                {
                    if (string1Array[i] == string2Array[i])
                    {
                        answer = "true";
                    }
                    else
                    {
                        answer = "false";
                        break;
                    }
                }

            }
            return answer;
        }
    }  

}