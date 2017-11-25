using System;

namespace _01.Dance_Hall
{
    class Program
    {
        static void Main(string[] args)
        {
            var lengthRoomInMeters = double.Parse(Console.ReadLine());
            var weightInMeters = double.Parse(Console.ReadLine());
            var warderobeSize = double.Parse(Console.ReadLine());

            double areaRoomInCm = (lengthRoomInMeters * 100) * (weightInMeters * 100);
            double areaBenchInCm = areaRoomInCm / 10;
            double areaWarderobeInCm = (warderobeSize * 100) * (warderobeSize * 100);
            double freeSpace = areaRoomInCm - areaBenchInCm - areaWarderobeInCm;
            double dancers = Math.Floor(freeSpace / (40 + 7000));
            Console.WriteLine(dancers);
        }
    }
}