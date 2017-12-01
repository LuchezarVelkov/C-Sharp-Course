using System;
using System.Linq;

namespace _06.Reverse_Array_of_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            var readData = Console.ReadLine().Split(' ').ToArray();
            for (int i = 0; i < readData.Length / 2; i++)
            {
                var exchangeValue = readData[(readData.Length - 1) - i];
                readData[(readData.Length - 1) - i] = readData[i];
                readData[i] = exchangeValue;
            }
            for (int i = 0; i < readData.Length; i++)
            {
                Console.Write(readData[i]+ " ");
            }
            Console.WriteLine();
        }
    }
}
