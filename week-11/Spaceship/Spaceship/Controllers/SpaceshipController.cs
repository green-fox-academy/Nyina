using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Spaceship.Viewmodels;
using Spaceship.Repositories;

namespace Spaceship.Controllers
{
    public class SpaceshipController : Controller
    {
        private SpaceshipRepository spaceshipRepository;

        public SpaceshipController(SpaceshipRepository spaceshipRepository)
        {
            this.spaceshipRepository = spaceshipRepository;
        }
    }
}
