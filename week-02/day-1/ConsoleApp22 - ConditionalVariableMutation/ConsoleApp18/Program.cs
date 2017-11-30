using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 24;
            Convert.ToInt32(a);
            int outt = 0;

            if (a % 2 == 0)
            {
                outt += 1;
            }
            
            Console.WriteLine(outt);
            Console.ReadLine();

            // if w is even increment out by one

            

            int b = 13;
            string out2="";

            if (10 < b && b < 20)
            {
                out2 = "Sweet";
            }
            if (b < 10)
            {
                out2 = "Less";
            }
            if (b > 20)
            {
                out2 = "More";
            }
            // if b is between 10 and 20 set out2 to "Sweet!"
            // if less than 10 set out2 to "More!",
            // if more than 20 set out2 to "Less!"

            Console.WriteLine(out2);
            Console.ReadLine();

            int c = 123;
            int credits = 100;
            bool isBonus = false;
            if (credits >= 50 && isBonus == false)
            {
                Console.WriteLine(c-2);
            }
            if (credits < 50 && isBonus == false)
            {
                Console.WriteLine(c-1);
            }
            if (isBonus == true)
            {
                Console.WriteLine(c);
            }
            Console.ReadLine();
            

            // if credits are at least 50,
            // and isBonus is false decrement c by 2
            // if credits are smaller than 50,
            // and isBonus is false decrement c by 1
            // if isBonus is true c should remain the same


            int d = 8;
            int ttime = 120;
            string out3 = "";
            if (d / 4 == 0 && ttime <= 200)
            {
                out3 = "check";
            }
            if (ttime > 200)
            {
                out3 = "Time out";
            }
            else
            {
                out3 = "Run Forest Run!";
            }

            // if d is dividable by 4
            // and time is not more than 200
            // set out3 to "check"
            // if time is more than 200
            // set out3 to "Time out"
            // otherwise set out3 to "Run Forest Run!"

            Console.WriteLine(out3);
            Console.ReadLine();
        }
    }
}