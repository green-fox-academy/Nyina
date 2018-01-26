using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using The_Reddit.Entities;
using The_Reddit.Models;

namespace The_Reddit.Repositories
{
    public class TheRedditRepository
    {
        private TheRedditContext theRedditContext;

        public TheRedditRepository (TheRedditContext theRedditContext)
        {
            this.theRedditContext = theRedditContext;
        }

        //public List<Post> Posts = new List<Post>();

        public List<Post> ShowList()
        {
            //A context todo dbset-jét listává kell alakítani
            //és eztv a controllerben meg kell hívni
            return theRedditContext.PoSts.Include(x => x.User).ToList();
        }

        public void CreateANewContent(Post post, string Name)
        {
            var oneUser = GetUser(Name);
            if (oneUser == null)
            {
                oneUser.Name = Name;
                post.User = oneUser;
            }
            else
            {
                post.User = oneUser;
            }
            theRedditContext.PoSts.Add(post);
            theRedditContext.SaveChanges();
        }

        public User GetUser(string name)
        {
            return theRedditContext.Users.FirstOrDefault(u => u.Name.Equals(name));
        }

        public void AddScore(Post post)
        {
            post.Score++;
            theRedditContext.SaveChanges();
        }

        public void DecreaseScore(Post post)
        {
            post.Score--;
            theRedditContext.SaveChanges();
        }
    }
}
