using Microsoft.EntityFrameworkCore;
using GreenfoxStore.Models;

namespace GreenfoxStore.Entities
{
    public class GreenfoxWebshopContext : DbContext
    {
        public GreenfoxWebshopContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<GreenfoxWebshop> GreenfoxWebshops { get; set; }

    }
}
