using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] DuplText = File.ReadAllLines("duplicated-chars.txt");
            //Létre kell hozni egy listát, mert listát ad vissza a függvény, így csak listába tölthető az eredmény
            List<string> okText = RepeatedLetters(DuplText);
            File.WriteAllLines("OkTxt.txt", okText);
            Console.ReadLine();
        }

        //meg kell adni, hogy listát adok vissza
        static List<string> RepeatedLetters(string[] file)
        {
            //listát kell használni, mert egy tömbhöz nem lehet hozzáadni
            List<string> resultResult = new List<string>();


            //sorok - a sorok így lesznek tömbből stringek
            foreach (var line in file)
            {
                //azért kell itt felvenni a buildert, hogy minden körnél létrejöjjön és kinullázza azt, amit appendel
                var builder = new StringBuilder();

                //karakterek - a stringekből karakterek lesznek
                for (int i = 0; i < line.Length - 1; i++)
                {
                    if (line[i] == line[i + 1])
                    {
                        //itt tesszük be a dupla karaktereket egyesével, ami egy sorban van
                        builder.Append(line[i + 1]);
                        i ++;
                    }
                }
                //visszafelé csomagolok: stringbe teszem bele a sort (amit az előbb builder-be tettem dupla karakterenként)
                string result = builder.ToString();
                //soronként tesszük bele a listába a duplikátumok nélküli sorokat
                resultResult.Add(result);
            }
            //ezt a listát adjuk vissza
            return (resultResult);
 
        }

    }
}
