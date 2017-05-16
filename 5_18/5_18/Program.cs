using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the credit limit check program");
            
            while (true)
            {
                Console.WriteLine("Fill in the details below to get the current status for the customers credit limit");
                Console.Write("Account number: ");
                var accountNumber = Console.ReadLine();
                Console.Write("Balance in the beginning of the month: ");
                var balanceInTheBeginningOfTheMonth = Console.ReadLine();
                Console.Write("Total charge so far this month: ");
                var chargedSoFar = Console.ReadLine();
                Console.Write("Total Credit so far this month: ");
                var creditSoFar = Console.ReadLine();
                Console.Write("Credit limit: ");
                var creditLimit = Console.ReadLine();

                var customerCredit = new CreditLimitCheck(Convert.ToInt32(accountNumber), Convert.ToInt32(balanceInTheBeginningOfTheMonth),
                    Convert.ToInt32(chargedSoFar), Convert.ToInt32(creditSoFar), Convert.ToInt32(creditLimit));

                if (customerCredit.IsCreditLimitExceeded)
                    Console.WriteLine("Credit limit exceeded");

                Console.WriteLine("Current monthly balance is {0} and the total balance is {1}", customerCredit.CurrentMonthlyBalance, customerCredit.TotalBalance);

                Console.WriteLine("If you want to test a new customer account type 'y', otherwise 'q' to quit");

                var decision = Console.ReadLine();
                if (String.Equals(decision, "q"))
                {
                    break;
                }
            }

            Console.WriteLine("Hit any key to exit");
            Console.ReadLine();
        }
    }
}
