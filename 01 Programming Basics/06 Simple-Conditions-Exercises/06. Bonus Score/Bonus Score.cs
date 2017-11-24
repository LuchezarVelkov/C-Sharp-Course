using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Bonus_Score
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = double.Parse(Console.ReadLine());
            var bonus = 0.00;
            if (num <= 100)
            {
                bonus += 5;
            }
            else if (num > 1001)
            {
                bonus += num * 10 / 100.0; // Плюс 20 %
            }
            else if (num > 100)
            {
                bonus += num * 20 / 100.0; // Плюс 20 %
            }

            if (num % 2 == 0)
            {
                bonus += 1;
            }

            if (num % 10 == 5)
            {
                bonus += 2;
            }

            Console.WriteLine(bonus);
            Console.WriteLine(num + bonus);
        }
    }
}
