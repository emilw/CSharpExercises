using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_4
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                throwDividedByZeroException();
            }
            catch(Exception ex)
            {
                Console.WriteLine("We are now catching all exceptions");
            }

            try
            {
                throwDividedByZeroException();
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("We are now catching only exceptions with division by zero");
            }
            catch(Exception ex)
            {
                Console.WriteLine("We are now catching all exceptions --- this will not be printed");
            }

            try
            {
                throw new InvalidCastException();
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("We are now catching only exceptions with division by zero --this will not be printed");
            }
            catch (Exception ex)
            {
                Console.WriteLine("We are now catching all exceptions, this got written due to that we throw a non division by zero exception");
            }

            Console.WriteLine("Hit any key to exit");
            Console.ReadLine();
        }

        private static void throwDividedByZeroException()
        {
            var zero = 0;
            var result = 10 / zero;
        }

    }
}
