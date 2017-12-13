using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fleet_of_Things
{
    class Program
    {
        public static void Main(string[] args)
        {

            var thing1 = new Thing("Get milk");
            var thing2 = new Thing("Remove the obstacles");
            var thing3 = new Thing("Stand up");
            var thing4 = new Thing("Eat lunch");

            thing3.Complete();
            thing4.Complete();

            Fleet fleetList = new Fleet();

            fleetList.Add(thing1);
            fleetList.Add(thing2);
            fleetList.Add(thing3);
            fleetList.Add(thing4);


            Console.ReadLine();


            // Create a fleet of things to have this output:
            // 1. [ ] Get milk
            // 2. [ ] Remove the obstacles
            // 3. [x] Stand up
            // 4. [x] Eat lunch
            // Hint: You have to create a Print method also
        }
    }
}
