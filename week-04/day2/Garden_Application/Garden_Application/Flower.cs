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

        //mivel a listát használom, abban benne van, hogy az objektumban milyen tulajdonságok és methodok vannak. Emiatt ok, ha ugyanaz a methid neve, de más a szorzó
        public double Watering()
        {
           return waterLevel = 0.75 * waterLevel;
        }

    }
}
