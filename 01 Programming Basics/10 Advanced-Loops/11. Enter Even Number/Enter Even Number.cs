using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Enter_Even_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter even number: ");
            var readNumber = int.Parse(Console.ReadLine());
            while (readNumber % 2 == 1)
            {
                Console.WriteLine("The number is not even.");
                Console.Write("Enter even number: ");
                readNumber = int.Parse(Console.ReadLine());
            }
            if (readNumber % 2 == 0)
            {
                Console.WriteLine("Even number entered: {0}",readNumber);
            }
        }
    }
}
