using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlogPost;

namespace Blog1
{
    public class Blog
    {
        //tulajdonságként létrehoztuk
        public List<BlogP> blogposts;

        //konstruktorban értéket kap
        public Blog()
        {
            blogposts = new List<BlogP>();
        }


        //itt pedig a blogpost objektumot adjuk hozzá
        public void AddBlogPost(BlogP blogpost)
        {
            blogposts.Add(blogpost);
        }

        public void RemoveBlogPost(int number)
        {
            blogposts.RemoveAt(number);
            foreach (var blogpost in blogposts)
            {   //nem lehet objektumot kiíratnim ezért egy tulajdonságot be kell írni (ahogyan a Programnál is kezeltem a kiírásokat, mert ott is a tulajdonságokat külön Console.WriteLine-oltam. Ha egyben akarom kiírni, akkor + jeleket kell a tulajdonságok közé írni)
                Console.WriteLine(blogpost.Title);
            }
        }

        public void updateBlogPost(BlogP blogposts, BlogP blogposts)
        {
            foreach ()

            blogposts[number3] = new List<BlogP>();
            blogposts.Add(blogposts)
            blogposts[number3] = blogposts[number1];
            blogposts[number1] = blogposts[number2];
            blogposts[number2] = tmp;
        }


    }
}
