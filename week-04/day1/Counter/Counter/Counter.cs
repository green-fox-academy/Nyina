using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Counter
{
    class Counter
    {
        public int num;
        public int currVal;

        public int CounterNum()
        {
            return num = 0;
        }

        public int CurrentValue()
        {
            return currVal = num;
        }

        public int AddNumber()
        {
            return currVal += 1;
        }

        public int Add()
        {
            return currVal++;
        }

        public string Get()
        {
            return currVal.ToString();
        }

        public int Reset()
        {
            return num = 0;
        }

    }
}
