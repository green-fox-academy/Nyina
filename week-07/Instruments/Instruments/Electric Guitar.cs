using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Instruments
{
    class Electric_Guitar : StringedInstrument
    {
        public string SoundElectricGuitar { get; set; }

        public Electric_Guitar(int stringsNumber)
        {
            this.NumberOfStrings = stringsNumber;
            Name = "Electric Guitar";
            SoundElectricGuitar = "Twang";
        }

        public override string Sound()
        {
            return SoundElectricGuitar;
        }

        public override void Play()
        {
            Console.WriteLine ("{0}, a {1}-stringed instrument that {2}", Name, NumberOfStrings.ToString(), Sound());
        }
    }
}
