using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Spaceship.Models
{
    public class SpaceShip
    {
        public long? Id { get; set; }
        public int MaxCapacity { get; set; }
        public string Planet { get; set; }
        public int Utilization { get; set; }
    }
}
