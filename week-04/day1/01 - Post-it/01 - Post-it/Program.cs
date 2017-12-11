using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _01___Post_it;

namespace _01___Post_it
{
    class Program
    {
        static void Main(string[] args)
        {
            var postItList = new PostIt();
            postItList.TextColor = "blue";
            postItList.BackgroundColor = "orange";
            postItList.Text = "Idea 1";

            Console.WriteLine(postItList.TextColor);
            Console.WriteLine(postItList.BackgroundColor);
            Console.WriteLine(postItList.Text);
            Console.ReadLine();
        }
    }
}
