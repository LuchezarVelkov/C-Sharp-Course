using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Christmas_Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            var count = int.Parse(Console.ReadLine());
            Console.Write(new string(' ',count+1));
            Console.WriteLine("|");
            var space = count -1;
            var rightStars = count - 1;
            for (int row = 1; row <= count; row++)
            {
                for (int whiteSpace = 1; whiteSpace <= space; whiteSpace++)
                {
                    Console.Write(' ');
                }
                Console.Write('*');
                for (int star = 1; star <= row -1; star++)
                {
                    Console.Write('*');
                }
                Console.Write(" | ");
                for (int right = 1; right <= row; right++)
                {
                    Console.Write('*');

                }
                Console.WriteLine();
                space--;
            }
        }
    }
}
