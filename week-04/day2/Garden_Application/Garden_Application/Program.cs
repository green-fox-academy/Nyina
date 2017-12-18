using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garden_Application
{
    class Program
    {
        static void Main(string[] args)
        {
            //Egy osztályt példányosítunk
            Garden gardens = new Garden();

            //Ezt az osztályt feltöltjük
            gardens.AddPlants(new Plant("Yellow Flower", 6, Plant.ThirstyLevelFlower, Plant.PlantAbsorbFlower));
            gardens.AddPlants(new Plant("Blue Flower", 2, Plant.ThirstyLevelFlower, Plant.PlantAbsorbFlower));
            gardens.AddPlants(new Plant("Purple Tree", 8, Plant.ThirstyLevelTree, Plant.PlantAbsorbTree));
            gardens.AddPlants(new Plant("Orange Tree", 3, Plant.ThirstyLevelTree, Plant.PlantAbsorbTree));


            gardens.GetWater(0);
            gardens.GetWater(40);
            gardens.GetWater(70);

            Console.ReadLine();
        }
    }
}