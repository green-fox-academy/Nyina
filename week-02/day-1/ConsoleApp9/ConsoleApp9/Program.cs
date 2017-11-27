using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double massInKg = 81.2;
            double heightInM = 1.78;

            double dheightInM = heightInM * heightInM;
            double BMI = massInKg / dheightInM;

            Console.WriteLine(BMI);
            Console.ReadLine();
        }
    }
}
