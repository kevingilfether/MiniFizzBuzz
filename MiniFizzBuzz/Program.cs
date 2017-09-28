using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniFizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            // This is MiniFizzBuzz
            Console.WriteLine("Give me a number:");
            int fizz = int.Parse(Console.ReadLine());

            Console.WriteLine("And another:");
            int buzz = int.Parse(Console.ReadLine());

            Console.WriteLine("I'm hungry, give me a test number.");
            int test = int.Parse(Console.ReadLine());

            //Conditionals taking test number and returning whether multiple of them:
            if (test % fizz == 0 && test % buzz == 0)
            {
                Console.WriteLine("FizzBuzz!");
            }
            else if (test % fizz == 0)
            {
                Console.WriteLine("Fizz!");
            }
            else if (test % buzz == 0)
            {
                Console.WriteLine("Buzz!");
            }
            else
            {
                Console.WriteLine(test);
            }
        }
    }
}
