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
            //listát kell használni, mert a tömbbe nem lehet hozzáadni
            List<string> resultResult = new List<string>();

            //ebbe a dupla karaktereket tesszük bele
            var builder = new StringBuilder();

            //sorok
            foreach (var line in file)
            {
                //karakterek
                for (int i = 0; i < line.Length - 1; i++)
                {
                    if (line[i] == line[i + 1])
                    {
                        //itt tesszük be a dupla karaktereket egyesével, ami egy sorban van
                        builder.Append(line[i + 1]);
                    }
                }
                //stringbe teszem bele a sort (amit az előbb builder-be tettem dupla karakterenként)
                string result = builder.ToString();
                //soronként tesszük bele a listába a duplikátumok nélküli sorokat
                resultResult.Add(result);
            }
            //ezt a listát adjuk vissza
            return (resultResult);
 
        }

    }
}
