using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PracticeWebshop.Models;
using Microsoft.EntityFrameworkCore;

namespace PracticeWebshop.Entities
{
    public class WebshopContext : DbContext
    {
        public WebshopContext(DbContextOptions options) : base (options)
        {
        }

        public DbSet<WebshopModel> PracticeWarehouse { get; set; }
    }
}
