using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            Counter numberCounter = new Counter();

            numberCounter.CounterNum();
            Console.WriteLine(numberCounter.num);

            numberCounter.CurrentValue();
            Console.WriteLine(numberCounter.currVal);

            numberCounter.AddNumber();
            Console.WriteLine(numberCounter.currVal);

            numberCounter.Add();
            Console.WriteLine(numberCounter.currVal);

            numberCounter.Get();
            Console.WriteLine(numberCounter.currVal);

            numberCounter.Reset();
            Console.WriteLine(numberCounter.num);

            Console.ReadLine();

        }
    }
}
