using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Name___Propertyvel
{
    class Name
    {
        //A megoldás: construktorban állítom be az 1. betű nagybetűt
        //protected string FirstName { get; set; }
        //protected string LastName { get; set; }

        //public Name(string firstName, string lastName)
        //{
        //    this.FirstName = char.ToUpper(firstName[0]) + firstName.Substring(1);
        //    this.LastName = char.ToUpper(lastName[0]) + lastName.Substring(1);
        //}

        //public string getName()
        //{
        //    return FirstName + " " + LastName;
        //}


        //B megoldás: külön funkcióban növelem az 1. betű méretét és ezeket a funkciókat teszem bele a kiíratásba
        protected string FirstName { get; set; }
        protected string LastName { get; set; }

        public Name(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public string setFirstName(string firstname)
        {
            firstname = char.ToUpper(firstname[0]) + firstname.Substring(1);
            return firstname;
        }

        public string setLastName(string lastname)
        {
            lastname = char.ToUpper(lastname[0]) + lastname.Substring(1);
            return lastname;
        }

        public string getName()
        {
            return setFirstName(FirstName) + " " + setLastName(LastName);
        }
    }
}
