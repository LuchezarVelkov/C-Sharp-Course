using System;

namespace _03.Last_K_Numbers_Sums
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            double[] seq = new double[n];
            seq[0] = 1;
            Console.Write($"{seq[0]} ");

            for (int i = 1; i < seq.Length; i++)
            {
                double result = 0;
                for (int i2 = i - k; i2 < i; i2++)
                {
                    if (i2 >= 0)
                    {
                        result += seq[i2];
                    }
                }
                seq[i] = result;
                Console.Write($"{result} ");

            }
        }
    }
}
