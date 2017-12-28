using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garden2
{
    public class Tree : Plant
    {

        public Tree(string name, double waterL) : base(name, waterL)
        {
            thirstLevel = 10;
            absorbPercent = 0.4;
        }
    }
}