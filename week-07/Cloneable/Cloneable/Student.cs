using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greenfox_organization
{
    public class Student : Person, ICloneable
    {
        public string previousOrganization;
        public int skippedDays;

        public object Clone()
        {
            return this;
        }

        public Student(string name, int age, string gender, string skippeddays) : base(name, age, gender)
        {
            previousOrganization = "The School of Life";
            skippedDays = 0;
        }

        public Student()
        {

        }


        public override void GetGoal()
        { //ha nem írom át, akkor az alapértelmezettet adja be. Ha átjuk, akkor így:

            Console.WriteLine("Be a junior software developer.");
        }

        public override void Introduce()
        {
            Console.WriteLine("Hi, I'm " + Name + ", a " + Age + " year old " + Gender + " from " + previousOrganization + " who skipped " + skippedDays + " days from the course already.");
        }

        public void SkipDays(int numberOfDays)
        {
            skippedDays += numberOfDays;
        }
    }
}
