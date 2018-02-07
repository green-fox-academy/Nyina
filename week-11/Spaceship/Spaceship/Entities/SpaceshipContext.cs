using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Spaceship.Models;
using Microsoft.EntityFrameworkCore;


namespace Spaceship.Entities
{
    public class SpaceshipContext : DbContext
    {
        public SpaceshipContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Planet> Planets { get; set; }
        public DbSet<SpaceShip> Spaceships { get; set; }

    }
}
