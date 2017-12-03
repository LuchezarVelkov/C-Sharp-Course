using System;
using System.Linq;

namespace _02.Rotate_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var numArray = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            int countRotations = int.Parse(Console.ReadLine());
            int[] sum = new int[numArray.Length];

            for (int i = 0; i < countRotations; i++)
            {
                int[] rotateArray = new int[numArray.Length];
                rotateArray[0] = numArray[numArray.Length -1];

                for (int iRotate = 0; iRotate < numArray.Length -1; iRotate++)
                {
                    rotateArray[iRotate +1] = numArray[iRotate];
                }

                for (int iSum = 0; iSum < sum.Length; iSum++)
                {
                    sum[iSum] += rotateArray[iSum];
                }
                numArray = rotateArray;
            }
            foreach (var item in sum)
            {
                Console.Write(item + " ");
            }
        }
    }
}
