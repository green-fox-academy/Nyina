using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greenfox_organization
{
    class Sponsor : Person
    {
        public string Company;
        public int HiredStudents;

        public Sponsor(string name, int age, string gender, string company) : base(name, age, gender)
        {
            Company = "Google";
            HiredStudents = 0;
        }

        public Sponsor()
        {

        }

        public override void Introduce()
        {
            Console.WriteLine("Hi, I'm" + Name + ", a" + Age + "year old" + Gender + "who represents" + Company + "and hired" + HiredStudents + "students so far.");
        }

        public void Hire()
        {
            HiredStudents++;
        }

        public override void GetGoal()
        {
            Console.WriteLine("Hire brilliant junior software developers.");
        }



    }
}
