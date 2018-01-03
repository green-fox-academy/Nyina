using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Instruments
{
    class Violin : StringedInstrument
    {
        public Violin(int stringsNumber)
        {
            NumberOfStrings = 4;
            Name = "Violin";
        }

        public override void Sound()
        {
            Console.WriteLine("Screech");
        }
    }
}
