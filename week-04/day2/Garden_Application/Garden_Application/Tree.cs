using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garden_Application
{
    class Tree : Plant
    {

        public Tree(double waterLevel)
        {
            thirstyLevel = 10;
            this.waterLevel = waterLevel;
        }


        public double Watering()
        {
            return waterLevel = 0.4 * waterLevel;
        }
    }
}
