using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sales person input program!");

            decimal[,] sales = { { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 } };

            while (true)
            {

                Console.Write("Enter sales person number (-1 to end): ");
                var personNumberInput = Console.ReadLine();
                if (String.Equals(personNumberInput, "-1"))
                {
                    break;
                }

                var personNumber = Convert.ToInt32(personNumberInput);

                Console.Write("Enter product number: ");
                var productNumberInput = Console.ReadLine();
                var productNumber = Convert.ToInt32(productNumberInput);

                Console.Write("Enter sales amount: ");
                var salesValueInput = Console.ReadLine();
                var salesValue = Convert.ToDecimal(salesValueInput);

                sales[personNumber-1, productNumber-1] += salesValue;
            }

            Console.Write("Product\t");
            for (int i = 0; i < 3; i++)
                Console.Write("Salesperson {0}\t", i + 1);

            Console.Write("Total\t");

            Console.Write(Environment.NewLine);

            for (int p = 0; p < 5; p++)
            {
                Console.Write("{0}\t", p+1);
                var total = 0m;
                for (int i = 0; i < 3; i++)
                {
                    Console.Write("${0:N2}\t\t", sales[i,p]);
                    total += sales[i, p];
                }
                Console.Write("${0:N2}", total);
                Console.Write(Environment.NewLine);
            }

            Console.Write("Total\t");
            for (int i = 0; i < 3; i++)
            {
                var total = 0m;
                for (int p = 0; p < 5; p++)
                {
                    total += sales[i, p];
                }
                Console.Write("${0:N2}\t\t", total);
            }
            
            Console.Write(Environment.NewLine);


            Console.WriteLine("Hit any key to exit");
            Console.ReadLine();
        }
    }
}
