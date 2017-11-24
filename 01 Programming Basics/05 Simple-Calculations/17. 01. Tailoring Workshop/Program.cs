using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17._01.Tailoring_Workshop
{
    class Program
    {
        static void Main(string[] args)
        {
            var tables = int.Parse(Console.ReadLine());
            double lenghtTablesInMeters = double.Parse(Console.ReadLine());
            double widthTablesInMeters = double.Parse(Console.ReadLine());

            double allCover = tables * (lenghtTablesInMeters + 2 * 0.30) * (widthTablesInMeters + 2 * 0.30);
            double allSquares = tables * ( lenghtTablesInMeters / 2 ) * (lenghtTablesInMeters / 2 );
            double courseUSD = 1.85;
            double priceCoverUsd = 7.00;
            double priceSquaresUsd = 9.00;

            double allCoverUSD = allCover * priceCoverUsd;
            double allSquaresUSD = allSquares * priceSquaresUsd;
            double priceUSD = allCoverUSD + allSquaresUSD;
            double priceBGN = priceUSD * courseUSD;
            Console.WriteLine("{0:f2} USD" , priceUSD);
            Console.WriteLine("{0:f2} BGN", priceBGN);
        }
    }
}
