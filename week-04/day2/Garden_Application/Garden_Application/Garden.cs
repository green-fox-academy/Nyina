using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garden_Application
{
    class Garden
    {
        public double thirstyLevel;
        public double waterLevel;
        public int counter;

        /*
        List<Flower> flowers = new List<Flower>();
        List<Tree> trees = new List<Tree>();*/

        List<Plant> plants = new List<Plant>();

        public int plantsContain()
        {
            for (int i = 0; i < 2; i++)
            {
                plants.Add(Plant);
                plants.Add(Tree);

                flowers.Add(new Flower());
                trees.Add(new Flower());

            }
        }

        

        public int whoIsThirsty()
        {
            foreach (var plant in plants)
            {
                if (waterLevel < thirstyLevel)
                {
                    counter++;
                }
                
            }
            return counter;
        }


    }
}
