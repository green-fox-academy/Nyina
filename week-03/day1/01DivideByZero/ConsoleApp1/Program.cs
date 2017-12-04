using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me a number!");
            int num = int.Parse(Console.ReadLine());
            Divider(num);


            // create a function that takes a number
            // divides ten with it,
            // and prints the result.
            // it should print "fail" if the parameter is 0
        }
        static void Divider(int number)
        {
            try
            {
                int result = (10 / number);
                Console.WriteLine(result);
            }
            catch
            {
                Console.WriteLine("fail");
            }
            /*VAGY
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            */
            finally
            {
                Console.ReadLine();
            }
        }

    }
}
