using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GreenfoxStore.Models;

namespace GreenfoxStore.Viewmodels
{
    public class GreenfoxWebshopViewmodel
    {
        public List<GreenfoxWebshop> GreenfoxTable { get; set; }
        public List<string> Sizes { get; set; }
        public List<string> ItemNames { get; set; }
    }
}
