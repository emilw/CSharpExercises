// Exercise 9.4 Solution: RectangleTest.cs 
// Application tests class Rectangle. 
using System;

namespace _10_3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle();

            int choice = GetMenuChoice();

            while (choice != 3)
            {
                switch (choice)
                {
                    case 1:
                        Console.Write("Enter length: ");
                        rectangle.Length = Convert.ToDouble(Console.ReadLine());
                        break;
                    case 2:
                        Console.Write("Enter width: ");
                        rectangle.Width = Convert.ToDouble(Console.ReadLine());
                        break;
                } // end switch 

                Console.WriteLine(rectangle.ToString());
                Console.WriteLine();

                choice = GetMenuChoice();
            } // end while 
        } // end Main 

        // prints a menu and returns a value corresponding to the menu choice 
        private static int GetMenuChoice()
        {
            Console.WriteLine("1. Set Length");
            Console.WriteLine("2. Set Width");
            Console.WriteLine("3. Exit");
            Console.Write("Choice: ");

            return Convert.ToInt32(Console.ReadLine());
        } // end method GetMenuChoice 
    } // end class RectangleTest
}