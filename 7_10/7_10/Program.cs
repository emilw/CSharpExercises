using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the credit limit check program");

            while (true)
            {
                Console.Write("Number to round: ");
                var value = Console.ReadLine();

                var number = Convert.ToDecimal(value);

                Console.WriteLine("The value given was {0}. \nRounding results: \nInt: {1} \nTenth: {2} \nHundredths: {3} \nThousandths {4}", number, RoundToInteger(number), RoundToTenths(number), RoundToHundredths(number), RoundToThousandsths(number));

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

        private static int RoundToInteger(decimal number)
        {
            return (int)RoundToX(number, 1);
        }

        private static decimal RoundToTenths(decimal number)
        {
            return RoundToX(number, 10);
        }

        private static decimal RoundToHundredths(decimal number)
        {
            return RoundToX(number, 100);
        }

        private static decimal RoundToThousandsths(decimal number)
        {
            return RoundToX(number, 1000);
        }

        private static decimal RoundToX(decimal number, decimal roundTo)
        {
            return Math.Floor(number * roundTo + 0.5m) / roundTo;
        }
    }
}
