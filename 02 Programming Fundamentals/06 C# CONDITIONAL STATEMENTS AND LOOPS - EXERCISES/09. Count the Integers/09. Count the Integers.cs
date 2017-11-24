using System;

namespace _09.Count_Integer
{
    class Program
    {
        static void Main(string[] args)
        {
            int readedNumbers = 0;
            while (true)
            {
                try
                {
                    int read = int.Parse(Console.ReadLine());
                    readedNumbers++;
                }
                catch (Exception)
                {
                    break;
                }
            }
            Console.WriteLine(readedNumbers);
        }
    }
}
