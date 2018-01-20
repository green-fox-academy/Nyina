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
            return theRedditContext.PoSts.ToList();
        }

        public User GetUser(string name)
        {
            theRedditContext.PoSts.Load();
            return theRedditContext.Users.FirstOrDefault(u => u.Name.Equals(name));
        }

        //public Post GetPost(long id)
        //{
        //    return theRedditContext.PoSts.FirstOrDefault(p => p.PostId == id);
        //}

        public void CreatePostToUser(string name, Post post)
        {
            post.User = GetUser(name);
            theRedditContext.PoSts.Add(post);
            theRedditContext.SaveChanges();
        }

        //public void CreateNewListItem(Post post)
        //{
        //    theRedditContext.PoSts.Add(post);
        //    theRedditContext.SaveChanges();
        //}

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
