using System;
namespace _07.Math_Power
{
    class Program
    {
        static void Main(string[] args)
        {
            double readNumber = double.Parse(Console.ReadLine());
            double readPower = double.Parse(Console.ReadLine());

            Console.WriteLine(MathPower(readNumber,readPower));
        }

        static double MathPower(double number, double power)
        {
            double sum = 1d;
            for (double i = 1; i <= power; i++)
            {
                sum = sum * number;
            }
            return sum;
        }
    }
}
