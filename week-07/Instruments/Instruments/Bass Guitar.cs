using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Instruments
{
    class Bass_Guitar : StringedInstrument
    {
        public Bass_Guitar(int stringsNumber)
        {
            NumberOfStrings = 4;
            Name = "Bass Guitar";
        }

        public override void Sound()
        {
            Console.WriteLine("Duum-duum-duum");
        }
    }
}
