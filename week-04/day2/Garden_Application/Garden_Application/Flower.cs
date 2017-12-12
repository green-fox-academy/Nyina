using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garden_Application
{
    class Flower : Plant
    {

        public Flower(double waterLevel)
        {
            thirstyLevel = 5;
            this.waterLevel = waterLevel;
        }


        public double Watering()
        {
           return waterLevel = 0.75 * waterLevel;
        }

    }
}
