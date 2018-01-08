using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloWorld.Models
{
    public class Greetings
    {
        public string Content { get; set; }
        public long Id { get; set; }

        public Greetings(long id, string name)
        {
            Id = id;
            Content = $"Hello, {name}!";
        }

        public Greetings()
        {

        }
    }
}
