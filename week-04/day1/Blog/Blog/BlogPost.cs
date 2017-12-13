using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Blog;

namespace BlogPost 
{
    public class BlogPost: Blog.Blog
    {
        public string AuthorName;
        public string Title;
        public string Text;
        public string PublicationDate;
    }
}
