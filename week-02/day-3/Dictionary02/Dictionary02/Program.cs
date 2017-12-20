using System;
using System.Collections.Generic;

namespace StudentCounter
{
    public class StudentCounter
    {
        public static void Main(string[] args)
        {
            //a map dictionary listákkal van feltöltve
            var map = new List<Dictionary<string, object>>();

            // Given this list of hashmaps...


            //Itt az object primitív típus, így előbb a Key stringekben kell kikeresni pl a candiest
            //és utána az értéket int-re konvertálni, hogy a "more candies than 4 candies"-t megtaláljuk
            var row0 = new Dictionary<string, object>();
            row0.Add("name", "Rezso");
            row0.Add("age", 9.5);
            row0.Add("candies", 2);
            map.Add(row0);

            var row1 = new Dictionary<string, object>();
            row1.Add("name", "Gerzson");
            row1.Add("age", 10);
            row1.Add("candies", 1);
            map.Add(row1);

            var row2 = new Dictionary<string, object>();
            row2.Add("name", "Aurel");
            row2.Add("age", 7);
            row2.Add("candies", 3);
            map.Add(row2);

            var row3 = new Dictionary<string, object>();
            row3.Add("name", "Zsombor");
            row3.Add("age", 12);
            row3.Add("candies", 5);
            map.Add(row3);

            var row4 = new Dictionary<string, object>();
            row4.Add("name", "Olaf");
            row4.Add("age", 12);
            row4.Add("candies", 7);
            map.Add(row4);

            var row5 = new Dictionary<string, object>();
            row5.Add("name", "Teodor");
            row5.Add("age", 3);
            row5.Add("candies", 2);
            map.Add(row5);

            // Display the following things:
            //  - Who has got more candies than 4 candies
            //  - Sum the age of people who have lass than 5 candies

            List<string> sortedPeopleList = new List<string>();
            int age = 0;

            foreach (var sortedPeople in map)
            {
                foreach (var sortedPerson in sortedPeople)
                {
                    if ((sortedPerson.Key == "candies") && (Convert.ToInt16(sortedPerson.Value) > 4))
                    {
                        sortedPeopleList.Add(Convert.ToString(sortedPeople["name"]));
                    }

                    if ((sortedPerson.Key == "candies") && (Convert.ToInt16(sortedPerson.Value) < 5))
                    {
                        age += Convert.ToInt16(sortedPeople["age"]);
                    }
                }

            }
            Console.WriteLine("Who has got more candies than 4 candies:");
            for (int i = 0; i < sortedPeopleList.Count; i++)
            {
                Console.WriteLine(sortedPeopleList[i]);
            }
            Console.WriteLine("Sum the age of people who have lass than 5 candies:" + age);

            Console.ReadLine();


        }
    }
}
