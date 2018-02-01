using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PracticeWebshop.Models;

namespace PracticeWebshop.Viewmodels
{
    public class Viewmodel
    {
        public List<WebshopModel> Clotehs { get; set; }
        public List<string> Sizes { get; set; }
        public List<string> Items { get; set; }
    }
}
