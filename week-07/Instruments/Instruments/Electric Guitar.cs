using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Instruments
{
    class Electric_Guitar : StringedInstrument
    {
        public Electric_Guitar(int stringsNumber)
        {
            NumberOfStrings = 6;
            Name = "Electric Guitar";
        }

        public override void Sound()
        {
            Console.WriteLine("Twang");
        }
    }
}
