using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_House
{
    class House
    {
        static void Main(string[] args)
        {
            var size = int.Parse(Console.ReadLine());
            var roofRows = (size + 1) / 2;
            var countOfStars = size % 2 == 0 ? 2 : 1;
            var countOfUnderscore = (size - countOfStars) / 2;
            int rooftopRows = (size + 1) / 2;
            
            for (int row = 1; row <= rooftopRows; row++)
            {
                string underscores = new string('-', countOfUnderscore);
                string stars = new string('*', countOfStars);

                Console.WriteLine("{0}{1}{0}", underscores, stars);
                countOfUnderscore--;
                countOfStars += 2;
            }
            int bodyRow = size / 2;
            for (int row = 0; row < bodyRow; row++)
            {
                string start = new string('*', size - 2);
                Console.WriteLine("|{0}|", start);
            }
        }
    }
}
