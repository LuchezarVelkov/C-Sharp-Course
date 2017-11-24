using System;

namespace _10.Multiplica_Table_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int readFirstNumber = int.Parse(Console.ReadLine());
            int readSecondNumber = int.Parse(Console.ReadLine());

            for (int i = readSecondNumber; i <= 10; i++)
            {
                var sum = readFirstNumber * i;
                Console.WriteLine($"{readFirstNumber} X {i} = {sum}");
            }

            if (readSecondNumber > 10)
            {
                var sum = readFirstNumber * readSecondNumber;
                Console.WriteLine($"{readFirstNumber} X {readSecondNumber} = {sum}");
            }
        }
    }
}
