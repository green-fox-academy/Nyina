using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlogPost;

namespace Blog 
{
    public class Blog
    {
        //objektumot várunk a listába
        List<BlogPost.BlogPost> blogposts = new List<BlogPost.BlogPost>();


        //itt pedig a blogpost objektumot adjuk hozzá
        public void AddBlogPost(BlogPost.BlogPost blogpost)
        {
            blogposts.Add(blogpost);
        }

        public void RemoveBlogPost(BlogPost.BlogPost blogpost, int number)
        {
            blogposts.Remove(blogpost, number);
        }


    }
}
