using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greenfox_organization
{
    public class Person
    {
        public string Name;
        public int Age;
        public string Gender;

        //miért nem adunk meg itt paramétert?
        public Person()
        {
            Name = "Jane Doe";
            Age = 30;
            Gender = "female";
        }

        //2 konstruktor kell, egy kitöltött és egy üres
        public Person(string name, int age, string gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }


        public virtual void Introduce()
        {
            Console.WriteLine("Hi, I'm " + Name + ", a " + Age + " year old " + Gender + ".");
        }

        public virtual void GetGoal()
        {
            Console.WriteLine("My goal is: Live for the moment!");
        }
    }
}
