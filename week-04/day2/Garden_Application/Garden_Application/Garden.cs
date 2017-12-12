using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garden_Application
{
    class Garden
    {
        public int waterFirst = 40;
        public int waterSecon = 70;
        public int waterAmount;


        public int GetFirstWater()
        {
            return waterAmount += waterFirst;
        }

        public int GetSecondWater()
        {
            return waterAmount += waterFirst;
        }
    }
}
