using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greenfox_organization
{
    class PallidaClass
    {
        public string className;

        List<Student> students = new List<Student>();
        List<Mentor> mentors = new List<Mentor>();

        //lista átadása paraméterként
        public PallidaClass()
        {
            //itt pedig üresként létehozom
            students = null;
            mentors = null;
        }

        //Itt miért kell a this-t kiírni a többinél pedig nem?
        public PallidaClass(string className)
        {
            this.className = className;
        }

        //itt pedig a diák objektumot adjuk hozzá
        public void AddStudent(Student student)
        {
            students.Add(student);
        }

        public void AddMentor(Mentor mentor)
        {
            mentors.Add(mentor);
        }

        public void Info()
        {
            //itt a lista méretét nézzük
            Console.WriteLine("Pallida " + className + " class has " + students.Count + " students and " + mentors.Count + " mentors.");
        }


    }
}
