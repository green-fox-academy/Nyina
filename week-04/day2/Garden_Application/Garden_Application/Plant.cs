using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garden_Application
{
    class Plant
    {
        public double thirstyLevel;
        public double waterLevel;

        public bool plantIsThirsty()
        {
            if (waterLevel < thirstyLevel)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
