using System;
using System.Collections.Generic;

namespace QuoteSwap
{
    public class QuoteSwap
    {
        public static void Main(string[] args)
        {
            var list = new List<string> { "What", "I", "do", "create,", "I", "cannot", "not", "understand." };
            list[2] = "cannot";
            list[5] = "do";

            foreach (string quote in list)
            {
                Console.Write(quote + " ");
            }
            Console.Read();

            //"What I cannot create, I do not understand" ?

            // Accidentally I messed up this quote from Richard Feynman.
            // Two words are out of place
            // Your task is to fix it by swapping the right words with code

            // Also, print the sentence to the output with spaces in between.

        }
    }
}