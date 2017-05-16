using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_12
{
    public class InvoiceLine
    {
        private int _quantity;
        private decimal _unitPrice;

        public InvoiceLine(string partNumber, string partDescription, int quantity, decimal unitPrice)
        {
            PartNumber = partNumber;
            PartDescription = partDescription;
            Quantity = quantity;
            UnitPrice = unitPrice;
        }

        public string PartNumber { get; set; }
        public string PartDescription { get; set; }
        public int Quantity {
            get
            {
                return _quantity;
            }
            set
            {
                if (value >= 0)
                    _quantity = value;
            }
        }

        public decimal UnitPrice {
            get
            {
                return _unitPrice;
            }
            set
            {
                if (value >= 0)
                    _unitPrice = value;
            }
        }
        public decimal LineTotal {
            get
            {
                return Quantity * UnitPrice;
            }
        }
    }
}
