using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PracticeLicences.Models;
using Microsoft.EntityFrameworkCore;

namespace PracticeLicences.Entities
{
    public class LicencesContext : DbContext
    {
        public LicencesContext (DbContextOptions options) : base(options)
        {
        }

        public DbSet<LicencesModel> TrialLicencePlates { get; set; }
    }
}
