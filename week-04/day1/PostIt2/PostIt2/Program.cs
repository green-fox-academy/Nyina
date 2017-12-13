using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostIt2
{
    class Program
    {
        static void Main(string[] args)
        {
            PostIt postits = new PostIt();
            postits.Background = "orange";
            postits.Text = "Idea1";
            postits.Textcolor = "blue";

            Console.WriteLine(postits.Background);
            Console.WriteLine(postits.Text);
            Console.WriteLine(postits.Textcolor);

            Console.ReadLine();

        }
    }
}
