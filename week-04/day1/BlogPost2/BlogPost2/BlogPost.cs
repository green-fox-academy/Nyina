using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogPost2
{
    class BlogPost
    {
        public string AuthorName;
        public string Title;
        public string Text;
        public string PublicationDate;

        //csak akkor kell a függvénynek paramétert adni, ha azok kívülről jönnek
        public void Print()
        {
            //azért nem kell megadni a classt, mert ott van a funkció, szóval ide tartozik
            //a this opcionális, a classra utal
            Console.WriteLine(this.AuthorName);
            Console.WriteLine(this.Title);
            Console.WriteLine(this.Text);
            Console.WriteLine(this.PublicationDate);

        }

        public void PrintToUpper()
        {
            Console.WriteLine(this.AuthorName.ToUpper());
            Console.WriteLine(this.Title.ToUpper());
            Console.WriteLine(this.Text.ToUpper());
        }

        public void PrintToUpperOrNot(int number)
        {

            if (number == 1)
            {
            Console.WriteLine(this.AuthorName);
            Console.WriteLine(this.Title);
            Console.WriteLine(this.Text);
            Console.WriteLine(this.PublicationDate);
            }

            if (number == 2)
            {
            Console.WriteLine(this.AuthorName.ToUpper());
            Console.WriteLine(this.Title.ToUpper());
            Console.WriteLine(this.Text.ToUpper());
            }
        }

    }
}
