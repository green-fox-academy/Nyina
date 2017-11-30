using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            int dailyHours = 6;
            int semesterWeeks = 17;
            int weekDays = 5;
            int AvarageWorkHours = 52;

            int codingHours = dailyHours * semesterWeeks * weekDays;
            double AvarageCodeHours = dailyHours * weekDays;
            
            Console.WriteLine(codingHours);
            Console.WriteLine(AvarageCodeHours / AvarageWorkHours);
            Console.ReadLine();
           
            
        }
    }
}