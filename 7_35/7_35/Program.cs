using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_35
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the power calculater");

            while (true)
            {
                Console.Write("The base: ");
                var baseInput = Console.ReadLine();

                var baseNumber = Convert.ToDecimal(baseInput);


                Console.Write("The exponent: ");
                var exponentInput = Console.ReadLine();

                int exponentNumber = Convert.ToInt32(exponentInput);

                Console.WriteLine("The base was set to {0} and the exponent to {1}, this gives {0}^{1}={2}", baseNumber, exponentNumber, Power(baseNumber, exponentNumber));

                Console.WriteLine("If you want to check a new value, type 'y', otherwise 'q' to quit");

                var decision = Console.ReadLine();
                if (String.Equals(decision, "q"))
                {
                    break;
                }
            }

            Console.WriteLine("Hit any key to exit");
            Console.ReadLine();
        }

        static decimal Power(decimal baseNumber, int exponent)
        {
            if (exponent == 1)
                return baseNumber;
            else if (exponent < 1)
                return 0;
            else
                return baseNumber * Power(baseNumber, exponent - 1);
        }
    }
}
