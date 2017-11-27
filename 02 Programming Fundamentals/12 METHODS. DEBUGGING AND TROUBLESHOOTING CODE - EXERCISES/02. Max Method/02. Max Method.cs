using System;

namespace _02.Max_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            int biggerFromOneAndTwo = GetMax(num1,num2);
            Console.WriteLine(GetMax(biggerFromOneAndTwo,num3));
        }

        static int GetMax(int num1, int num2)
        {
            int bigger = 0;
            if (num1 > num2)
            {
                    bigger = num1;
            }
            else
            {
                bigger = num2;
            }
            return bigger;
        }
    }
}
