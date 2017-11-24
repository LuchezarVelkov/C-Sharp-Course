using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_Aquarium
{
    class Program
    {
        static void Main(string[] args)
        {
            var lenghtCm = int.Parse(Console.ReadLine());
            var widthCm = int.Parse(Console.ReadLine());
            var heightCm = int.Parse(Console.ReadLine());
            double procentCm = Math.Round(double.Parse(Console.ReadLine()),3);

            double totalLiters = (lenghtCm * widthCm * heightCm) * 0.001;
            double procent = procentCm * 0.01;
            double LiterNeed = Math.Round(totalLiters * (1 - procent),3);
            Console.WriteLine(LiterNeed);
        }
    }
}
