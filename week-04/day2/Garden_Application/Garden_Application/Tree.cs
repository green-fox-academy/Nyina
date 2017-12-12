using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garden_Application
{
    class Tree : Garden
    {
        public double treerWaterAmount;
        public double number;

        public Tree(double number)
        {
            this.number = number;
        }

        public double treeWatering()
        {
            return treerWaterAmount = 0.4 * waterAmount;
        }
    }
}
