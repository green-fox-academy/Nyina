using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fleet_of_Things
{
    class Thing
    {
        private string Name;
        private bool Completed;

        public Thing(string name)
        {
            this.Name = name;
        }

        public void Complete()
        {
            this.Completed = true;
        }
    }
}
