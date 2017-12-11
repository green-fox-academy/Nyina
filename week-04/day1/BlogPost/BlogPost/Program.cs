using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogPost
{
    class Program
    {
        static void Main(string[] args)
        {
            var blogPost1 = new BlogPost();
            blogPost1.Title = "Lorem Ipsum";
            blogPost1.AuthorName = "John Doe";
            blogPost1.PublicationDate = "2000.05.04";
            blogPost1.Text = "Lorem ipsum dolor sit amet";

            Console.WriteLine(blogPost1.Title);
            Console.WriteLine(blogPost1.AuthorName);
            Console.WriteLine(blogPost1.PublicationDate);
            Console.WriteLine(blogPost1.Text);


            var blogPost2 = new BlogPost();
            blogPost2.Title = "Wait but why";
            blogPost2.AuthorName = "Tim Urban";
            blogPost2.PublicationDate = "2010.10.10.";
            blogPost2.Text = "A popular long-form, stick-figure-illustrated blog about almost everything.";

            Console.WriteLine(blogPost2.Title);
            Console.WriteLine(blogPost2.AuthorName);
            Console.WriteLine(blogPost2.PublicationDate);
            Console.WriteLine(blogPost2.Text);


            var blogPost3 = new BlogPost();
            blogPost3.Title = "One Engineer Is Trying to Get IBM to Reckon With Trump";
            blogPost3.AuthorName = "William Turton";
            blogPost3.PublicationDate = "2017.03.28.";
            blogPost3.Text = "Daniel Hanley, a cybersecurity engineer at IBM, doesn’t want to be the center of attention. When I asked to take his picture outside one of IBM’s New York City offices, he told me that he wasn’t really into the whole organizer profile thing.";

            Console.WriteLine(blogPost3.Title);
            Console.WriteLine(blogPost3.AuthorName);
            Console.WriteLine(blogPost3.PublicationDate);
            Console.WriteLine(blogPost3.Text);
            Console.ReadLine();

        }
    }
}
