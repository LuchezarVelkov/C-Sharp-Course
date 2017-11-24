using System;

namespace _09.Multiplicati_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int readNumber = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {
                var sum = readNumber * i;
                Console.WriteLine($"{readNumber} X {i} = {sum}");
            }
        }
    }
}
