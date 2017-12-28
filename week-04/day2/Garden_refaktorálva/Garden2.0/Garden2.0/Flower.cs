using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garden2
{
    public class Flower : Plant
    {

        public Flower(string name, double waterL) : base(name, waterL)
        {
            thirstLevel = 5;
            absorbPercent = 0.75;
        }

    }
}