using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Sum_Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            string readNumber = Console.ReadLine();
            int sum = 0;
            for (int i = 0; i <= readNumber.Length - 1; i++)
            {
                char symbol = readNumber[i];
                int number = int.Parse(symbol.ToString());
                sum += number;
            }
            Console.WriteLine(sum);

            //var readNumber = int.Parse(Console.ReadLine());
            //int sum = 0;

            //while (readNumber != 0)
            //{
            //    var lastDigit = readNumber % 10;
            //    sum += lastDigit;

            //    readNumber = readNumber / 10; 
            //}
            //Console.WriteLine(sum);
        }
    }
}
