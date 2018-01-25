using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using The_Reddit.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;

namespace The_Reddit.Entities
{
    public class The_RedditContext : DbContext
    {
        public The_RedditContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Post> RedditP { get; set; }
        public DbSet<User> RedditU { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                 .HasMany(x => x.Posts)
                 .WithOne(x => x.User)
                 .HasPrincipalKey(x => x.UserId);
        }
    }
}
