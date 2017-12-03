using System;
using System.Linq;

namespace _03.Fold_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int k = numbers.Length / 4;

            int[] leftArray = numbers.Take(k).ToArray();
            int[] middleArray = numbers.Skip(k).Take(k * 2).ToArray();
            int[] rightArray = numbers.Skip(k * 3).Take(k).ToArray();

            Array.Reverse(leftArray);
            Array.Reverse(rightArray);

            int[] result = new int[k*2];

            for (int i = 0; i < k; i++)
            {
                result[i] = middleArray[i] + leftArray[i];
                result[i + k] = middleArray[i + k] + rightArray[i];
            }

            Console.WriteLine($"{string.Join(" ", result)}");


            //int[] readNumber = Console.ReadLine()
            //    .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
            //    .Select(int.Parse)
            //    .ToArray();
            //int[] newArray = new int[readNumber.Length / 2];
            //int[] middleArray = new int[readNumber.Length / 2];

            //while (true)
            //{
            //    int[] startArray = new int[readNumber.Length / 4];
            //    int[] endArray = new int[readNumber.Length / 4];
            //    for (int getStartAndEnd = 0; getStartAndEnd < readNumber.Length / 4; getStartAndEnd++)
            //    {
            //        startArray[getStartAndEnd] = readNumber[(readNumber.Length / 4) - 1 - getStartAndEnd];
            //        endArray[getStartAndEnd] = readNumber[readNumber.Length - 1 - getStartAndEnd];
            //    }
            //    for (int iNewArrayStart = 0; iNewArrayStart < readNumber.Length / 4; iNewArrayStart++)
            //    {
            //        newArray[iNewArrayStart] = startArray[iNewArrayStart];
            //    }
            //    for (int iNewArrayEnd = 0; iNewArrayEnd < readNumber.Length / 4; iNewArrayEnd++)
            //    {
            //        newArray[iNewArrayEnd + readNumber.Length / 4] = endArray[iNewArrayEnd];
            //    }
            //    break;
            //}

            //for (int iSum = 0; iSum < readNumber.Length /2; iSum++)
            //{
            //    Console.Write(newArray[iSum] + readNumber[readNumber.Length / 4 + iSum] + " ");
            //}
        }
    }
}
