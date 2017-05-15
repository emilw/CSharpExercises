using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_12
{
    public class Inovice
    {
        public string InvoiceNumber { get; set; }
        public List<InvoiceLine> Lines {get;set;}

        public decimal TotalAmount
        {
            get
            {
                return Lines.Select(x => x.TotalAmount).Sum();
            }
        }
    }
}
