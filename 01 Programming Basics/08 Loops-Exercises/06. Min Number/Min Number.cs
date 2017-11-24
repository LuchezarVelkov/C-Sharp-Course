using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Min_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbersToRead = int.Parse(Console.ReadLine());
            var minNumber = int.MaxValue;
            for (int i = 0; i < numbersToRead; i++)
            {
                var readNum = int.Parse(Console.ReadLine());
                if (readNum < minNumber)
                {
                    minNumber = readNum;
                }
                Console.WriteLine(minNumber);
            }
        }
    }
}
