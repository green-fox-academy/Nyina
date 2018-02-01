using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PracticeWebshop.Models
{
    public class Summary
    {
        public string ItemName { get; set; }
        public string Manufacturer { get; set; }
        public string Category { get; set; }
        public string Size { get; set; }
        public int Amount { get; set; }
        public double TotalPrice { get; set; }
    }
}
