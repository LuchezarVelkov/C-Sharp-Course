using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Odd__Even_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            var readNumbers = int.Parse(Console.ReadLine());
            var oddSum = 0.0;
            var oddMin = double.MaxValue;
            var oddMax = double.MinValue;
            var evenSum = 0.0;
            var evenMin = double.MaxValue;
            var evenMax = double.MinValue;

            for (int i = 1; i <= readNumbers; i++)
            {
                var inputNumber = double.Parse(Console.ReadLine());
                if (i % 2 == 1)
                {
                    oddSum += inputNumber;
                    if (inputNumber < oddMin)
                    {
                        oddMin = inputNumber;
                    }
                    if (inputNumber > oddMax)
                    {
                        oddMax = inputNumber;
                    }
                }
                else
                {
                    evenSum += inputNumber;
                    if (inputNumber < evenMin)
                    {
                        evenMin = inputNumber;
                    }
                    if (inputNumber > evenMax)
                    {
                        evenMax = inputNumber;
                    }
                }
            }
            Console.WriteLine("OddSum=" + oddSum + ",");
            if (oddMin == double.MaxValue)
            {
                Console.WriteLine("OddMin=No,");
            }
            else
            {
                Console.WriteLine("OddMin=" + oddMin + ",");
            }
            if (oddMax == double.MinValue)
            {
                Console.WriteLine("OddMax==No,");
            }
            else
            {
                Console.WriteLine("OddMax=" + oddMax + ",");
            }
            Console.WriteLine("EvenSum=" + evenSum + ",");
            if (evenMin == double.MaxValue || evenMin == 0)
            {
                Console.WriteLine("EvenMin=No,");
            }
            else
            {
                Console.WriteLine("EvenMin=" + evenMin + ",");
            }
            if (evenMax == double.MinValue)
            {
                Console.WriteLine("EvenMax=No");
            }
            else
            {
                Console.WriteLine("EvenMax=" + evenMax);
            }
        }
    }
}
