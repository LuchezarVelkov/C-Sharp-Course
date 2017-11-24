using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Diamond
{
    class Diamond
    {
        static void Main(string[] args)
        {
            var size = int.Parse(Console.ReadLine());
            var topStars = (size % 2) == 0 ? 2 : 1;
            int countOfSideDashes = (size - topStars) / 2;
            string stars = new string('*', topStars);
            string dashes = new string('-', countOfSideDashes);
            if (size == 1)
            {
                Console.WriteLine("*");
            }
            else if (size == 2)
            {
                Console.WriteLine("**");
            }
            else
            {
                Console.WriteLine("{0}{1}{0}", dashes, stars);

                var countOfMiddleDashes = topStars;
                var countOfNewSideDashes = countOfSideDashes - 1;
                var diamondPart = (size % 2) == 0 ? (size / 2) - 1 : (size / 2);
                for (int topRows = 0; topRows < diamondPart; topRows++)
                {
                    string strCountOfSideDashes = new string('-', countOfNewSideDashes);
                    string strCountOfMiddleDashes = new string('-', countOfMiddleDashes);
                    Console.WriteLine("{0}*{1}*{0}", strCountOfSideDashes, strCountOfMiddleDashes);
                    countOfNewSideDashes = countOfNewSideDashes == 0 ? (countOfNewSideDashes = 0) : (countOfNewSideDashes - 1);
                    countOfMiddleDashes = countOfMiddleDashes + 2;
                }

                countOfNewSideDashes = 1;
                countOfMiddleDashes = size - 4;
                diamondPart = (size % 2) == 0 ? (size / 2) - 2 : (size / 2) - 1;
                for (int bottomRow = 0; bottomRow < diamondPart; bottomRow++)
                {
                    string strCountOfSideDashes = new string('-', countOfNewSideDashes);
                    string strCountOfMiddleDashes = new string('-', countOfMiddleDashes);
                    Console.WriteLine("{0}*{1}*{0}", strCountOfSideDashes, strCountOfMiddleDashes);
                    countOfNewSideDashes = countOfNewSideDashes + 1;
                    countOfMiddleDashes = countOfMiddleDashes - 2;
                }

                Console.WriteLine("{0}{1}{0}", dashes, stars);
            }
        }
    }
}
