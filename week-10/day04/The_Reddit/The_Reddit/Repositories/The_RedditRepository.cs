using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using The_Reddit.Entities;
using The_Reddit.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace The_Reddit.Repositories
{
    public class The_RedditRepository
    {
        private The_RedditContext theRedditContext;

        public The_RedditRepository(The_RedditContext theRedditContext)
        {
            this.theRedditContext = theRedditContext;
        }


        public List<Post> GetList()
        {
            return theRedditContext.RedditP.ToList();
        }

        public void AddPost(Post post)
        {
            theRedditContext.RedditP.Add(post);
            theRedditContext.SaveChanges();
        }

        public User GetAUser(string Name)
        {
            return theRedditContext.RedditU.FirstOrDefault(x => x.UserName == Name);
        }

        public void AddPostWithUsers(ModelForMethodsDatas mothodDatas)
        {
            var onePost = new Post();
            onePost.PostId = mothodDatas.PostId;
            onePost.Title = mothodDatas.Title;
            onePost.Url = mothodDatas.Url;
            onePost.Timastamp = mothodDatas.Timastamp;
            onePost.Score = mothodDatas.Score;
            onePost.User.UserName = mothodDatas.UserName;
            onePost.User.Vote = mothodDatas.Vote;

            theRedditContext.Add(onePost);
            theRedditContext.SaveChanges();
        }

        public Post GetAPost()
        {
            return theRedditContext.RedditP.Last();
        }

        public Post GetAPostWithUser(long id)
        {
            return theRedditContext.RedditP.Include(x => x.User).Last(x => x.PostId == id);
        }
    }
}
