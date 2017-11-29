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
            string todoText = " - Buy milk\n";
            string todoText0 = "My todo:\n";
            string todoText2 = " - Download games\n";
            string todoText3 = "    - Diablo";

            Console.WriteLine(todoText0 + todoText + todoText2 + todoText3);
            Console.ReadLine();

            // Add "My todo:" to the beginning of the todoText
            // Add " - Download games" to the end of the todoText
            // Add " - Diablo" to the end of the todoText but with indention

            // Expected output:

            // My todo:
            //  - Buy milk
            //  - Download games
            //      - Diablo

            Console.WriteLine(todoText);
        }
    }
}
