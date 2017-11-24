using System;

namespace _13.Game_of_Numbe
{
    class Program
    {
        static void Main(string[] args)
        {
            int readNumberN = int.Parse(Console.ReadLine());
            int readNumberM = int.Parse(Console.ReadLine());
            int magicalNumber = int.Parse(Console.ReadLine());
            int combinations = 0;
            string lastKnownCombination = null;

            for (int num1 = readNumberN; num1 <= readNumberM; num1++)
            {
                for (int num2 = readNumberN; num2 <= readNumberM; num2++)
                {
                    combinations++;
                    if (num1 + num2 == magicalNumber)
                    {
                        lastKnownCombination = $"Number found! {num1} + {num2} = {magicalNumber}";
                    }
                }
            }
            if (lastKnownCombination != null)
            {
                Console.WriteLine(lastKnownCombination);
            }
            else
            {
                Console.WriteLine($"{combinations} combinations - neither equals {magicalNumber}");
            }
        }
    }
}
