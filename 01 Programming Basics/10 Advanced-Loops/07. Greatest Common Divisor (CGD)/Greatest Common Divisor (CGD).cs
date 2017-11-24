using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Greatest_Common_Divisor__CGD_
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            while (secondNumber != 0)  // Пресмятане на най-голям  общ делител.
            {
                var result = firstNumber % secondNumber;
                firstNumber = secondNumber;
                secondNumber = result;
            }
            Console.WriteLine(firstNumber);
        }
    }
}
