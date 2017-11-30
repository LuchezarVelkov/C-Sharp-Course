using System;

namespace _02.Reverse_Array_of_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            for (int reverse = array.Length -1; reverse >= 0; reverse--)
            {
                Console.Write($"{array[reverse]} ");

            }
            Console.WriteLine();
        }
    }
}
