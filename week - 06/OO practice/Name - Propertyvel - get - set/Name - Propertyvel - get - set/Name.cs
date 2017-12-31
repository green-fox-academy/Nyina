using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Name___Propertyvel___get___set
{
    class Name
    {
        //itt szoktak a névadásnál _-t használni
        private string FirstName;
        private string LastName;

        //Property definiálása, mert szétszedtük a public string FirstName{ get; set;} -et
        //ez azért public, mert automatikusan létrejön a háttérben a propertyhez tartozó, fenti private field
        //ez az egyszerűbb eset, így ha variálni akarok a get-set-tel, akkor nekem kell létrehozni a public fieldeket is
        public string firstName
        {
            get
            {
                return this.FirstName;
            }
            set
            {
                //Ez lenne itt, ezért kell a firstname helyére a value-t írni
                //this.FirstName = value;
                this.FirstName = char.ToUpper(value[0]) + value.Substring(1);

                //Ha exception-nel szeretnénk hibát kezelni, akkor pl így lehetne:
                //if (value != "ádám")
                //throw new Exception("It's not a firstname");
                //vagy pl:
                //if (value != "ádám")
                //throw new Exception("It's not a firstname");

            }
        }

        //Lehet ezután constructor-t csinálni, de akkor a fenti get-set-en keresztül 

        public string lastName
        {
            get
            {
                return this.LastName;
            }
            set
            {
                this.LastName = char.ToUpper(value[0]) + value.Substring(1);
            }
        }

        public string getName()
        {
            return FirstName + " " + LastName;
        }

        //Lehet azt is, hogy Name propertyt hozok létre és a getternél adom meg a funkcióban return-ölteket
    }
}
