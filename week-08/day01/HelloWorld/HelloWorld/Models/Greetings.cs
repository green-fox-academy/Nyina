using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloWorld.Models
{
    public class Greetings
    {
        public int Id { get; set; }
        public string Content { get; set; }

        public Greetings(string name)
        {
            Id = 2;
            Content = $"Hello,{name}!";
        }
    }
}
