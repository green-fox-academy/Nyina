using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garden_Application
{
    public class Plant
    {
        public double PlantAbsorb { get; set; }
        public string Name { get; set; }
        public double WaterLevel { get; set; }
        public double ThirstyLevel { get; set; }
        public const double ThirstyLevelFlower = 5;
        public const double ThirstyLevelTree = 10;
        public const double PlantAbsorbFlower = 0.75;
        public const double PlantAbsorbTree = 0.4;


        public Plant(string plantName, double waterl, double thirstl, double plantA)
        {
            this.Name = plantName;
            this.WaterLevel = waterl;
            this.ThirstyLevel = thirstl;
            this.PlantAbsorb = plantA;
        }

        public void WaterIt(int waterAmount)
        {
            WaterLevel = WaterLevel + waterAmount * PlantAbsorb;
        }

    }
}
