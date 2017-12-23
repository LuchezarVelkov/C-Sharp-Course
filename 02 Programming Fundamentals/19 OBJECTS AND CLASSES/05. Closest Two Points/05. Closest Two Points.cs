using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ClosestTwoPoints
{
    static void Main(string[] args)
    {
        Point[] points = ReadPoints();
        Point[] closestPoints = FindClosestPoints(points);
        Console.WriteLine("{0:F3}", CalculateDistance(closestPoints[0], closestPoints[1]));
        foreach (var point in closestPoints)
        {
            Console.WriteLine($"({point.X}, {point.Y})");

        }
    }

    private static double CalculateDistance(Point point1, Point point2)
    {
        double sideA = point1.X - point2.X;
        double sideB = point1.Y - point2.Y;
        double distan = Math.Sqrt(sideA * sideA + sideB * sideB);
        return distan;
    }

    private static Point[] FindClosestPoints(Point[] points)
    {
        Point[] closestPoints = new Point[2];
        double minimalDistance = double.MaxValue;

        for (int i = 0; i < points.Length; i++)
        {
            for (int j = i + 1; j < points.Length; j++)
            {
                if (CalcPointDistance(points[i], points[j]) < minimalDistance)
                {
                    minimalDistance = CalcPointDistance(points[i], points[j]);
                    closestPoints[0] = points[i];
                    closestPoints[1] = points[j];
                }
            }
        }
        return closestPoints;
    }

    static double CalcPointDistance(Point point1, Point point2)
    {
        int deltaX = point1.X - point2.X;
        int deltaY = point1.Y - point2.Y;

        return Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
    }

    private static Point[] ReadPoints()
    {
        int pointsCount = int.Parse(Console.ReadLine());
        Point[] points = new Point[pointsCount];

        for (int i = 0; i < pointsCount; i++)
        {
            int[] readPoint = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            points[i] = new Point { X = readPoint[0], Y = readPoint[1] };
        }
        return points;
    }

    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
    }

}