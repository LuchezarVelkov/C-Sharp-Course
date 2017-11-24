using System;

namespace _11._5_Dif_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int readA = int.Parse(Console.ReadLine());
            int readB = int.Parse(Console.ReadLine());
            if (readB - readA >= 4)
            {
                for (int num1 = readA; num1 <= readB; num1++)
                {
                    for (int num2 = num1 + 1; num2 <= readB; num2++)
                    {
                        for (int num3 = num2 + 1; num3 <= readB; num3++)
                        {
                            for (int num4 = num3 + 1; num4 <= readB; num4++)
                            {
                                for (int num5 = num4 + 1; num5 <= readB; num5++)
                                {
                                    Console.WriteLine($"{num1} {num2} {num3} {num4} {num5}");
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
