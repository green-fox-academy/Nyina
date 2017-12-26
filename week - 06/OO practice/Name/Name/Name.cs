using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Name
{
    class Name
    {
        protected string firstName;
        protected string lastName;

        //A megoldás konstruktorral és seterrel, ami mindkét nevet egyben kezeli
        //public Name(string firstname, string lastname)
        //{
        //    this.firstName = firstname;
        //    this.lastName = lastname;
        //}

        //public void SetName()
        //{
        //    firstName = FirstLetterUpper(firstName);
        //    lastName = FirstLetterUpper(lastName);
        //}


        //B megoldás konstruktor nélkül és külön seterrel, ami a neveket külön kezeli
        public void SetFirstname(string firstname)
        {
            firstName = FirstLetterUpper(firstname);
        }

        public void SetLastname(string lastname)
        {
            lastName = FirstLetterUpper(lastname);
        }

        public string GetName()
        {
            return (firstName + " " + lastName);
        }

        public string FirstLetterUpper(string firstname)
        {
            return char.ToUpper(firstname[0]) + firstname.Substring(1);
        }

    }
}
