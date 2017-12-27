using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Name___Propertyvel
{
    class Name
    {

        protected string FirstName { get; set; }
        protected string LastName { get; set; }

        public Name(string firstName, string lastName)
        {
            this.FirstName = char.ToUpper(firstName[0]) + firstName.Substring(1);
            this.LastName = char.ToUpper(lastName[0]) + lastName.Substring(1);
        }

        public string getName()
        {
            return FirstName + " " + LastName;
        }



    }
}
