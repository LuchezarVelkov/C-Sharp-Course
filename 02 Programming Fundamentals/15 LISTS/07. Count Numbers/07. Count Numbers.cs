using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count_Numbers
{
    class Count_Numbers
    {
        static void Main(string[] args)
        {
            List<int> readNumbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            readNumbers.Sort();

            int index = 0;
            List<int> numbers = new List<int>();
            List<int> repeats = new List<int>();

            while (readNumbers.Count >= 1)
            {
                int currentNumber = readNumbers[index];
                numbers.Add(readNumbers[index]);
                int count = 1;
                for (int i = index + 1; i < readNumbers.Count; i++)
                {
                    if (readNumbers[index] == readNumbers[i])
                    {
                        count++;
                    }
                }
                while (readNumbers.Remove(currentNumber))
                {
                    readNumbers.Remove(currentNumber);
                }
                repeats.Add(count);
            }

            for (int i = 0; i < numbers.Count; i++)
            {
                Console.WriteLine($"{numbers[i]} -> {repeats[i]}");

            }

            //List<int> numbers = Console.ReadLine()
            //    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            //    .Select(int.Parse)
            //    .ToList();
            //foreach (var number in numbers.Distinct().OrderBy(x => x))
            //    Console.WriteLine(string.Join(" -> ",
            //        number,
            //        numbers.Count(x => x == number)));
        }
    }
}