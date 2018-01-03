using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Instruments
{
    abstract class StringedInstrument : Instrument
    {
        public int NumberOfStrings { get; set; }

        public abstract void Sound();
    }
}
