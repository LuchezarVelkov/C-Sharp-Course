using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Distance_between_Points
{
    class Program
    {
        static void Main(string[] args)
        {
            Point pointOne = PointReader(Console.ReadLine());
            Point pointTwo = PointReader(Console.ReadLine());
            double result = CalculateDiferenceOfPoint(pointOne,pointTwo);
            Console.WriteLine(result.ToString("F3"));
        }

        private static double CalculateDiferenceOfPoint(Point pointOne, Point pointTwo)
        {
            int deltaX = pointOne.X - pointTwo.X;
            int deltaY = pointOne.Y - pointTwo.Y;
            double result = Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
            return result;
        }

        private static Point PointReader(string input)
        {
            int[] point = input.Split(' ').Select(int.Parse).ToArray();
            return new Point { X = point[0], Y = point[1] };
        }

        public class Point
        {
            public int X { get; set; }
            public int Y { get; set; }
        }
    }
}
