using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_24
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                int number = 0;
                Console.WriteLine("Give me a number(or 'q' to quit):");
                var input = Console.ReadLine();

                if (String.Equals(input, "q"))
                {
                    break;
                }
                else if (!Int32.TryParse(input, out number))
                {
                    Console.WriteLine("The input was not a valid number");
                    continue;
                }

                var rest = number % 2;

                if (rest == 0)
                    Console.WriteLine("It's even!");
                else
                    Console.WriteLine("It's odd!");
            }
            Console.WriteLine("Hit any key to exit");
            Console.ReadLine();
        }
    }
}
