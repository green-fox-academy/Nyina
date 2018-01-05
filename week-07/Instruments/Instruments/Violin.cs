using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Instruments
{
    class Violin : StringedInstrument
    {
        public string SoundViolin { get; set; }

        public Violin(int stringsNumber)
        {
            this.NumberOfStrings = stringsNumber;
            Name = "Violin";
            SoundViolin = "Screech";
        }

        public override string Sound()
        {
            return SoundViolin;
        }

        public override void Play()
        {
            Console.WriteLine("{0}, a {1}-stringed instrument that {2}", Name, NumberOfStrings.ToString(), Sound());
        }
    }
}
