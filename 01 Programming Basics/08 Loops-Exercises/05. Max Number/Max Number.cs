using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Max_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbersToRead = int.Parse(Console.ReadLine());
            var bigestNumber = int.MinValue;
            for (int i = 0; i < numbersToRead; i++)
            {
                var number = int.Parse(Console.ReadLine());
                if (number > bigestNumber)
                {
                    bigestNumber = number;
                }
            }
            Console.WriteLine(bigestNumber);
        }
    }
}
