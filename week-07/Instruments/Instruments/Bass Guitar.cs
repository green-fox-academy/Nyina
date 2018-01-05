using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Instruments
{
    class Bass_Guitar : StringedInstrument
    {
        public string SoundBassGuitar { get; set; }

        public Bass_Guitar(int stringsNumber)
        {
            this.NumberOfStrings = stringsNumber;
            Name = "Bass Guitar";
            SoundBassGuitar = "Duum-duum-duum";
        }

        public override string Sound()
        {
            return SoundBassGuitar;
        }

        public override void Play()
        {
            Console.WriteLine("{0}, a {1}-stringed instrument that {2}", Name, NumberOfStrings.ToString(), Sound());
        }
    }
}
