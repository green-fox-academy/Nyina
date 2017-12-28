using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garden2
{
    public class Garden
    {
        //A kertet feltöltjük növényekkel, emiatt kell plants listátá létehozni - ami még üres
        List<Plant> plantList = new List<Plant>();

        //A listát feltöltjük a plant objektum elemeivel
        public void AddPlants(Plant plant)
        {
            plantList.Add(plant);
        }

        public void ShareWater(int GardenWaterLevel)
        {
            int thirstPlantsCounter = 0;
            int WaterAmount = 0;

            //Ha van locsolás, akkor írja ki
            if (GardenWaterLevel != 0)
            {
                Console.WriteLine("Watering with {0}", GardenWaterLevel);
            }

            foreach (var plant in plantList)
            {
                if (plant.WaterLevel < plant.thirstLevel)
                {
                    Console.WriteLine("The {0} needs water", plant.Name);
                    thirstPlantsCounter++;
                }
                else
                {
                    Console.WriteLine("The {0} doesnt need water", plant.Name);
                }
            }
            if (thirstPlantsCounter != 0)
            {
                WaterAmount = GardenWaterLevel / thirstPlantsCounter;
                foreach (var plant in plantList)
                {
                    if (plant.WaterLevel < plant.thirstLevel)
                    {
                        plant.GetWater(WaterAmount);
                    }
                }
            }

        }
    }
}