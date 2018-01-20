using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using The_Reddit.Models;

namespace The_Reddit.Entities
{
    public class TheRedditContext : DbContext
    {
        public TheRedditContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Post> PoSts { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                 .HasMany(x => x.PoSts)
                 .WithOne(x => x.User)
                 .HasPrincipalKey(x => x.UserId);
        }
    }
}
