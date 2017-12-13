using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlogPost;

namespace Blog : BlogPost
{
    class Blog
    {
        //objektumot várunk a listába
        List<BlogPost> blogposts = new List<BlogPost>();


        //itt pedig a blogpost objektumot adjuk hozzá
        public void AddBlogPost(BlogPost blogpost)
        {
            blogposts.Add(blogpost);
        }

        public void RemoveBlogPost(BlogPost blogpost)
        {
            blogposts.Remove(blogpost);
        }


}
}
