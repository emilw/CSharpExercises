using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_12
{
    public class InvoiceTest
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the invoice generator program");
            Console.Write("Provide an invoice number: ");
            var invoiceNumber = Console.ReadLine();
            var invoice = new Invoice(invoiceNumber);

            while (true)
            {
                Console.WriteLine("Add an item line to the invoice by typing in the following:");
                Console.Write("Part description: ");
                var partDescription = Console.ReadLine();
                Console.Write("Part number: ");
                var partNumber = Console.ReadLine();
                Console.Write("Quantity: ");
                var quantity = Console.ReadLine();
                Console.Write("Unit price: ");
                var unitPrice = Console.ReadLine();

                var lineCreatedCorrectly = invoice.AddInvoiceLine(partNumber, partDescription, Convert.ToInt32(quantity), Convert.ToDecimal(unitPrice));

                if (!lineCreatedCorrectly)
                    Console.WriteLine("The new item could not be added to the invoice, please check that all amounts are positive.");
            

                Console.WriteLine("Grand total so far {0}", invoice.TotalAmount);
                Console.WriteLine("If you want to add a new line type 'y', otherwise 'q' to quit");

                var decision = Console.ReadLine();
                if (String.Equals(decision, "q"))
                {
                    break;
                }
            }

            Console.WriteLine("Invoice {0} with {1} lines and a total of {2} have been generated", invoice.InvoiceNumber, invoice.Lines.Count, invoice.TotalAmount);

            Console.WriteLine("Hit any key to exit");
            Console.ReadLine();
        }
    }
}
