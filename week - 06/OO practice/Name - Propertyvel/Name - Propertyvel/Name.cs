using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Name___Propertyvel
{
    class Name
    {

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

        protected string FirstName { get; set; }
        protected string LastName { get; set; }

        public Name(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        //string FirstName;
        //string LastName;

        //public string firstName
        //{
        //    get
        //    {
        //        return this.FirstName;
        //    }
        //    set
        //    {
        //        this.FirstName = value;
        //    }
        //}

        //public string lastName
        //{
        //    get
        //    {
        //        return this.LastName;
        //    }
        //    set
        //    {
        //        this.LastName = value;
        //    }
        //}

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
