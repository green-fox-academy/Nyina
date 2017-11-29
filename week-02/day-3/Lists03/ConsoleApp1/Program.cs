using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var far = new List<string> { "kuty", "macsk", "kacs", "rók", "halacsk" };
            // Add "a" to every string in the far list.


            for (int i = 0; i < far.Count; i++)
            {
                far[i] += "a";
                //far.Insert(far[i] + "a");
            }

            //string finishedList = finishedList.Concat(far)+('a').ToList();

            foreach (string animal in far)
            {
                Console.WriteLine(animal);
            }
                Console.ReadLine();
        }
    }
}
