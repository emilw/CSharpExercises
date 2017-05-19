using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Duplicate word removal!");

            while (true)
            {

                Console.Write("Enter a sentence(-1 to quit): ");
                var sentenceInput = Console.ReadLine();
                if (String.Equals(sentenceInput, "-1"))
                {
                    break;
                }

                var words = sentenceInput.Split().Select(x => x.ToLower());

                var onlySingleWords = words.GroupBy(x => x).Where(x => x.Count() == 1).Select(x => x.First());

                foreach (var word in onlySingleWords.OrderBy(x => x))
                {
                    Console.WriteLine(word);
                }
            }

            Console.WriteLine("Hit any key to exit");
            Console.ReadLine();
        }
    }
}
