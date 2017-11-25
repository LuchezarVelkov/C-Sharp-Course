using System;

namespace _05.Cup
{
    class Program
    {
        static void Main(string[] args)
        {
            int readNumber = int.Parse(Console.ReadLine());

            for (int i = 0; i < readNumber / 2; i++)
            {
                Console.WriteLine("{0}{1}{0}", new string('.', readNumber + i), new string('#', 3 * readNumber - (i * 2)));
            }
            for (int i = 0; i < readNumber / 2 + 1; i++)
            {
                Console.WriteLine("{0}#{1}#{0}", new string('.', 3 * readNumber / 2 + i), new string('.', readNumber * 2 - 2 - (i * 2)));
            }
            Console.WriteLine("{0}{1}{0}", new string('.', readNumber * 2), new string('#', readNumber));

            for (int i = 0; i < readNumber / 2; i++)
            {
                Console.WriteLine("{0}{1}{0}", new string('.', readNumber * 2 - 2), new string('#', readNumber + 4));
            }
            Console.WriteLine("{0}D^A^N^C^E^{0}", new string('.', (5 * readNumber - 10) / 2));
            for (int i = 0; i < readNumber / 2 + 1; i++)
            {
                Console.WriteLine("{0}{1}{0}", new string('.', readNumber * 2 - 2), new string('#', readNumber + 4));
            }
        }
    }
}
