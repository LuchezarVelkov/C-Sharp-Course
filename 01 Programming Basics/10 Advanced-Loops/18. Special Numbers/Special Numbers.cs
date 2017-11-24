using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var readNumber = int.Parse(Console.ReadLine());

            for (int num1 = 1; num1 <= 9; num1++)
            {
                for (int num2 = 1; num2 <= 9; num2++)
                {
                    for (int num3 = 1; num3 <= 9; num3++)
                    {
                        for (int num4 = 1; num4 <= 9; num4++)
                        {
                            if (readNumber % num1 == 0 && readNumber % num2 == 0 && readNumber % num3 == 0 &&
                                readNumber % num4 == 0)
                            {
                                Console.Write("{0}{1}{2}{3} ", num1, num2, num3, num4);
                            }
                        }
                    }
                }
            }
        }
    }
}
