using System;

namespace _10.Cube_Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            double readNumber = double.Parse(Console.ReadLine());
            string readString = Console.ReadLine().ToLower(); //(face, space, volume or area)
            if (readString == "face")
            {
                Console.WriteLine(CubeFace(readNumber));
            }
            else if (readString == "space")
            {
                Console.WriteLine(CubeSpace(readNumber));
            }
            else if (readString == "volume")
            {
                Console.WriteLine(CubeVolume(readNumber));
            }
            else if (readString == "area")
            {
                Console.WriteLine(CubeArea(readNumber));
            }
        }

        static string CubeArea(double readNumber)
        {
            double result = 6 * Math.Pow(readNumber, 2);
            return $"{result:F2}";
        }

        static string CubeVolume(double readNumber)
        {
            double result = Math.Pow(readNumber, 3);
            return $"{result:F2}";
        }

        static string CubeSpace(double readNumber)
        {
            double result = Math.Sqrt(3 * Math.Pow(readNumber, 2));
            return $"{result:F2}";
        }

        static string CubeFace(double readNumber)
        {
            double result = Math.Sqrt(2 * Math.Pow(readNumber,2));
            return $"{result:F2}";
        }
    }
}
