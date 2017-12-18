using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greenfox_organization
{
    class Mentor : Person
    {
        public string Level;

        public Mentor(string name, int age, string gender, string level) : base(name, age, gender)
        {
            Level = "Intermediate";
        }

        public Mentor()
        {

        }

        public override void GetGoal()
        {
            Console.WriteLine("Educate brilliant junior software developers.");
        }

        public override void Introduce()
        {
            Console.WriteLine("Hi, I'm " + Name + ", a " + Age + " year old " + Gender + Level + " mentor.");
        }



    }
}
