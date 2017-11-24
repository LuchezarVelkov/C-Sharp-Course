using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Number_in_Range_1_to_100
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Еnter a number in the range [1...100]: ");
            var readNumber = int.Parse(Console.ReadLine());

            while (readNumber > 100 || readNumber < 1)
            {
                Console.WriteLine("Invalid number!");
                Console.Write("Еnter a number in the range [1...100]: ");
                readNumber = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("The number is: {0}", readNumber);
        }
    }
}
