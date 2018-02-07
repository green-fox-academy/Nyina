using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Spaceship.Entities;
using Spaceship.Viewmodels;

namespace Spaceship.Repositories
{
    public class SpaceshipRepository
    {
        private SpaceshipContext spaceshipContext;

        public SpaceshipRepository(SpaceshipContext spaceshipContext)
        {
            this.spaceshipContext = spaceshipContext;
        }
    }
}
