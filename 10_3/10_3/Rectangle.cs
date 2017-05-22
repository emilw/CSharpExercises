using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_3
{
    public class Rectangle
    {
        private double length = 1;
        private double width = 1;

        public double Length {
            get
            {
                return length;
            }
            set
            {
                if (isValid(value))
                    length = value;
            }
        }
        public double Width {
            get
            {
                return width;
            }
            set
            {
                if (isValid(value))
                    width = value;
            }
        }
        public double Perimiter
        {
            get
            {
                return (Length * 2) +  (Width*2);
            }
        }

        public double Area
        {
            get
            {
                return Length * Width;
            }
        }

        private bool isValid(double number)
        {
            return number < 20 && number > 0 ? true : false;
        }

        public override string ToString()
        {
            return String.Format("Length: {0} and Width: {1} \nArea: {2} \nPerimiter: {3}", Length, Width, Area, Perimiter);
        }
    }
}
