using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Add_Two_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstNumber = int.Parse(Console.ReadLine());
            var secondNumber = int.Parse(Console.ReadLine());
            var sum = firstNumber + secondNumber;
            Console.WriteLine("{0} + {1} = {2}",firstNumber,secondNumber,sum);
        }
    }
}
