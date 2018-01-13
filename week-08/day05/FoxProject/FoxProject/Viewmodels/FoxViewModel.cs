using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoxProject.Models;

namespace FoxProject.Viewmodels
{
    public class FoxViewModel
    {
        public List<Fox> FoxList { get; set;  } = new List<Fox>();

        public FoxViewModel()
        {
            AddToList();
        }

        public void AddToList()
        {
            FoxList.Add(new Fox()
            {
                Name = "Karak",
                Food = "Salad",
                Drink = "Water",
                Tricks = { }
            });

            FoxList.Add(new Fox()
            {
                Name = "Vuk",
                Food = "Burrito",
                Drink = "Orange juice",
                Tricks = { "See sharp", "C#"}
            });
        }
    }
}
