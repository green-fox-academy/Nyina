using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garden2
{
    public class Plant
    {
        public string Name { get; set; }
        public double WaterLevel { get; set; }
        public double absorbPercent { get; set; }
        public double thirstLevel { get; set; }

        public Plant(string name, double waterL)
        {
            this.Name = name;
            this.WaterLevel = waterL;
        }

        public void GetWater(int WaterAmount)
        {
            WaterLevel = WaterLevel + WaterAmount * absorbPercent;
        }

    }
}