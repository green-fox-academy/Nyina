using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoxProject.Models
{
    public class Fox
    {
        public string Name { get; set; } = string.Empty;
        public List<string> Tricks { get; set; }
        public string Food { get; set; }
        public string Drink { get; set; }
    }
}
