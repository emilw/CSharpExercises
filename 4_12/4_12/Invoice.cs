using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_12
{
    public class Invoice
    {
        string _invoiceNumber;

        public Invoice(string invoiceNumber)
        {
            InvoiceNumber = invoiceNumber;
            Lines = new List<InvoiceLine>();
        }

        public bool AddInvoiceLine(string partNumber, string partDescription, int quantity, decimal unitPrice)
        {
            if (quantity < 0 || unitPrice < 0)
                return false;

            var line = new InvoiceLine(partNumber, partDescription, quantity, unitPrice);
            Lines.Add(line);
            return true;
        }
        public string InvoiceNumber { get; private set; }

        public List<InvoiceLine> Lines {get;set;}

        public decimal TotalAmount
        {
            get
            {
                return Lines.Select(x => x.LineTotal).Sum();
            }
        }
    }
}
