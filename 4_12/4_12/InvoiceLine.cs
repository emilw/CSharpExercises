using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_12
{
    public class InvoiceLine
    {
        public string PartNumber { get; set; }
        public string PartDescription { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal TotalAmount {
            get
            {
                return Quantity * UnitPrice;
            }
        }
    }
}
