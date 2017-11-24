using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Check_Prime
{
    class Program
    {
        static void Main(string[] args)
        {
            var readNumber = int.Parse(Console.ReadLine());
            bool isPrime = true;
            if (readNumber <= 1)
            {
                Console.WriteLine("Not Prime");
                return;
            }
            for (int i = 2; i <= readNumber -1; i++)
            {
                if (readNumber % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            string result = isPrime ? "Prime" : "Not Prime";
            Console.WriteLine(result);
        }
    }
}
