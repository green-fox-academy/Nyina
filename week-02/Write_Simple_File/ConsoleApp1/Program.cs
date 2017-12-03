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
            //string text = "This is now a new information";
            //System.IO.File.WriteAllText("NewTxt.txt", text);

            string[] line = { "This is now a new information", "This is the second", "This is the last" };
            System.IO.File.WriteAllLines("NewTxt.txt", line);
        }
    }
}
