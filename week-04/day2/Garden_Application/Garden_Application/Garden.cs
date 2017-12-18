using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garden_Application
{
    public class Garden
    {
        //Létre kell hozni az üres objektum listát a növényeknek
        public List<Plant> plants = new List<Plant>();

        //Hogy aztán feltölthessük a kertet növényekkel
        public void AddPlants(Plant plant)
        {
            plants.Add(plant);
        }



        public void GetWater(int WaterLevel)
        {
            int plantCounter = 0;
            int waterAmount = 0;
            Console.WriteLine("Watering with {0}", WaterLevel);

            foreach (var plant in plants)
            {
                if (plant.WaterLevel < plant.ThirstyLevel)
                {
                    Console.WriteLine("The {0} needs water", plant.Name);
                    plantCounter++;
                }
                
                else
                {
                    Console.WriteLine("The {0} doesnt need water", plant.Name);
                } 
            }
            if (plantCounter != 0)
            {
                waterAmount = (WaterLevel / plantCounter);
                foreach (var plant in plants)
                {
                    if (plant.WaterLevel < plant.ThirstyLevel)
                    {
                        plant.WaterIt(waterAmount);
                        //plant.WaterLevel = plant.WaterLevel + waterAmount * plant.PlantAbsorb;
                    }
                }
            }
        }
    }
}


