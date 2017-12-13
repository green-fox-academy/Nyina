using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogPost2
{
    class Program
    {
        static void Main(string[] args)
        {
            BlogPost posts0 = new BlogPost();

            posts0.Title = "Lorem Ipsum";
            posts0.AuthorName = "John Doe";
            posts0.PublicationDate = "2000.05.04.";
            posts0.Text = "Lorem ipsum dolor sit amet.";

            //posts0.Print();

            Console.WriteLine();

            //posts0.PrintToUpper();

            Console.WriteLine();

            posts0.PrintToUpperOrNot(1);
            posts0.PrintToUpperOrNot(2);

            Console.WriteLine();
            Console.WriteLine();

            BlogPost posts1 = new BlogPost();

            posts1.Title = "Wait but why";
            posts1.AuthorName = "Tim Urban";
            posts1.PublicationDate = "2010.10.10.";
            posts1.Text = "A popular long-form, stick - figure - illustrated blog about almost everything.";

            posts1.Print();


            Console.WriteLine();
            Console.WriteLine();

            BlogPost posts2 = new BlogPost();

            posts2.Title = "One Engineer Is Trying to Get IBM to Reckon With Trump";
            posts2.AuthorName = "William Turton";
            posts2.PublicationDate = "2017.03.28.";
            posts2.Title = "Daniel Hanley, a cybersecurity engineer at IBM, doesn’t want to be the center of attention. When I asked to take his picture outside one of IBM’s New York City offices, he told me that he wasn’t really into the whole organizer profile thing.";

            posts2.Print();


            Console.ReadLine();

        }
    }
}
