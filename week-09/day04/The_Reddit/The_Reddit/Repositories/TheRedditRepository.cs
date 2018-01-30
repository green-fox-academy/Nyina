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

            //return theRedditContext.PoSts.Include(x => x.User).ToList();
            //var item = theRedditContext.PoSts.OrderByDescending(x => x.Score).ToList();

            var item = theRedditContext.PoSts.Include(x => x.User).OrderByDescending(x => x.Score).ToList();
            return item;
        }

        public User GetUser(string name)
        {
            return theRedditContext.Users.FirstOrDefault(u => u.Name.Equals(name));
        }

        public void CreateANewContent(Post post, string Name)
        {
            var oneUser = GetUser(Name);
            if (oneUser == null)
            {
                var postObject = new User();
                postObject.Name = Name;
                post.User = postObject;
            }
            else
            {
                post.User = oneUser;
            }
            theRedditContext.PoSts.Add(post);
            theRedditContext.SaveChanges();
        }

        //post lita userid szerint és userrel együtt
        public List<Post> GetLoggedInUsersPost(int id)
        {
            return theRedditContext.PoSts.Include(u => u.User)
                .Where(t => t.PostId == id)
                .ToList();
        }

        //ugyanaz, mint az előző csak név alapján szűr
        public List<Post> GetAUsersListItem(string name)
        {
            return theRedditContext.PoSts.Where(t => t.User.Name == name).ToList();
        }


        public void AddScore(long id)
        {
            var item = theRedditContext.PoSts.FirstOrDefault(t => t.PostId == id);
            item.Score++;
            //theRedditContext.PoSts.Update(Item);
            theRedditContext.SaveChanges();
        }

        public void DecreaseScore(long id)
        {
            var item = theRedditContext.PoSts.FirstOrDefault(t => t.PostId == id);
            item.Score--;
            //theRedditContext.PoSts.Update(Item);
            theRedditContext.SaveChanges();
        }


        //public List<Post> top5()
        //{
        //    var item = theRedditContext.PoSts.OrderByDescending(x => x.Score).ToList();
        //    var topElements = new List<Post>();
        //    for (int i = 0; i < 5; i++)
        //    {
        //        topElements.Add(topElements[i]);
        //    }
        //    return topElements;
        //}



    }
}
