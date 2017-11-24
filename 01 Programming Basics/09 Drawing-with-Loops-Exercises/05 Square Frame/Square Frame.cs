using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Square_Frame
{
    class Program
    {
        static void Main(string[] args)
        {
            var size = int.Parse(Console.ReadLine());
            var topAndBottonText = "+";
            var middleText = "|";
                for (int i2 = 1; i2 <= size -2; i2++)
                {
                    topAndBottonText = topAndBottonText + " -";
                }
            topAndBottonText = topAndBottonText + " +";
            for (int i2 = 1; i2 <= size -2; i2++)
            {
                middleText = middleText + " -";
            }
            middleText = middleText + " |";
            Console.WriteLine(topAndBottonText);
            for (int i3 = 1; i3 <= size -2; i3++)
            {
                Console.WriteLine(middleText);
            }
            Console.WriteLine(topAndBottonText);
        }
    }
}
