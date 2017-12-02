using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me a number! Let's check together wether it is an Armstrong number!");
            int number = Convert.ToInt32(Console.ReadLine());
            
            //int numOfDigits = input.Count(char.IsDigit);

            double result = 0;
            int numberLength = Length(number);
            

            //char.GetNumericValue(number);
            //var digits = SeparateTheDigits(number);
            //var numberList = new int[] { number };

            var digits = number.ToString();
            var numberArray = digits.ToString();

            for (int i = 0; i <= numberLength; i++ )
            {
                double numer= Convert.ToDouble(number);
                double numberLength1 = Convert.ToDouble(numberLength);
                result += Math.Pow(numberArray[i], numberLength1);
            }
            Convert.ToInt32(result);
            if (result == number)
                {
                Console.WriteLine("WOW, You have an Armstorng number!");
                }
            else
                {
                Console.WriteLine("Keep trying!");
                }
            Console.ReadLine();

        }
        public static int Length(int number)
        {
            number = Math.Abs(number);
            int length = 1;
            while ((number /= 10) >= 1)
                length++;
            return length;
        }
    }
}
