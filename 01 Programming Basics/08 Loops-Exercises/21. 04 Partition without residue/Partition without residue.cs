using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21._04_Partition_without_residue
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbersToRead = int.Parse(Console.ReadLine());
            var partitionTo2 = 0;
            var partitionTo3 = 0;
            var partitionTo4 = 0;

            for (int i = 1; i <= numbersToRead; i++)
            {
                var read = int.Parse(Console.ReadLine());
                if (read % 2 == 0)
                {
                    partitionTo2++;
                }
                if (read % 3 == 0)
                {
                    partitionTo3++;
                }
                if (read % 4 == 0)
                {
                    partitionTo4++;
                }
            }
            var step = 100.00 / numbersToRead;
            var proc2 = partitionTo2 * step;
            var proc3 = partitionTo3 * step;
            var proc4 = partitionTo4 * step;
            Console.Write("{0:f2}", proc2);
            Console.WriteLine("%");
            Console.Write("{0:f2}", proc3);
            Console.WriteLine("%");
            Console.Write("{0:f2}", proc4);
            Console.WriteLine("%");
        }
    }
}
