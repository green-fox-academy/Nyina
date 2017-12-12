using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garden_Application
{
    class Flower : Garden
    {
        public double flowerWaterAmount;
        public double number;

        public Flower(double number)
            {
                this.number = number;
            }

        public double flowerWatering()
        {
           return flowerWaterAmount = 0.75 * waterAmount;
        }

    }
}
