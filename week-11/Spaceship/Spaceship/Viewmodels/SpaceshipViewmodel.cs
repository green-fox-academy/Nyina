using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Spaceship.Models;

namespace Spaceship.Viewmodels
{
    public class SpaceshipViewmodel
    {
        public List<Planet> Planets { get; set; }
        public SpaceShip Spaceship { get; set; }
    }
}
