using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarLicences.Models;
using Microsoft.EntityFrameworkCore;

namespace CarLicences.Entities
{
    public class LicencePlatesContext : DbContext
    {
        public LicencePlatesContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<LicencePlatesModel> licencePlates { get; set; }
    }
}
