using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_17
{
    class Program
    {
        private static Random random = new Random();
        
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the dice roller!");
            var runs = 36000;

            while (true)
            {
                int[] result = new int[11];
                Console.WriteLine("Rolling dices");
                for (int i = 0; i < runs; i++)
                {
                    var dice1 = Roll();
                    var dice2 = Roll();

                    result[(dice1 + dice2) - 2] += 1;
                }

                Console.WriteLine("Total sum of throws: {0}", result.Sum(x => x));

                for (int i = 0; i < result.Length; i++)
                    Console.Write("{0}\t", i+2);

                Console.Write(Environment.NewLine);

                for(int i = 0; i < result.Length; i++)
                {
                    Console.Write("{0}\t", result[i]);
                }
                Console.Write(Environment.NewLine);

                for (int i = 0; i < result.Length; i++)
                {
                    Console.Write("{0:N2}%\t", ((decimal)result[i]/(decimal)runs)*100);
                }
                Console.Write(Environment.NewLine);

                Console.WriteLine("If you want to roll again, type 'y', otherwise 'q' to quit");

                var decision = Console.ReadLine();
                if (String.Equals(decision, "q"))
                {
                    break;
                }
            }

            Console.WriteLine("Hit any key to exit");
            Console.ReadLine();
        }

        public static int Roll()
        {
            return random.Next(1, 7);
        }
    }
}
