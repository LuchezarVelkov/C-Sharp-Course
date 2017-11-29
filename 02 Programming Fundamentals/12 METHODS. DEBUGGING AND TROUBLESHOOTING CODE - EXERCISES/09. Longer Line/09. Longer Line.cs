using System;

namespace _09.Longer_Line
{
    class Program
    {
        static void Main(string[] args)
        {
            double startFirstLineX1 = double.Parse(Console.ReadLine());
            double startFirstLineY1 = double.Parse(Console.ReadLine());
            double endFirstLineX2 = double.Parse(Console.ReadLine());
            double endFirstLineY2 = double.Parse(Console.ReadLine());
            double startSecondLineX1 = double.Parse(Console.ReadLine());
            double startSecondLineY2 = double.Parse(Console.ReadLine());
            double endSecondLineX1 = double.Parse(Console.ReadLine());
            double endSecondLineY2 = double.Parse(Console.ReadLine());

            Console.WriteLine(CoordinatesOfFourPoints(startFirstLineX1,
                startFirstLineY1,endFirstLineX2,endFirstLineY2,startSecondLineX1,
                startSecondLineY2,endSecondLineX1,endSecondLineY2));
        }

        private static string CoordinatesOfFourPoints(double startFirstLineX1, double startFirstLineY1,
            double endFirstLineX2, double endFirstLineY2, double startSecondLineX1, double startSecondLineY1,
            double endSecondLineX2, double endSecondLineY2)
        {
            //double firstHypotenuseStart = Math.Abs(Math.Sqrt(Math.Pow(startFirstLineX1,2) + Math.Pow(startFirstLineY1,2)));
            //double firstHypotenuseStop = Math.Abs(Math.Sqrt(Math.Pow(endFirstLineX2, 2) + Math.Pow(endFirstLineY2, 2)));
            double firstLine = Math.Sqrt((endFirstLineX2 - startFirstLineX1) * (endFirstLineX2 - startFirstLineX1) +
                (endFirstLineY2 - startFirstLineY1) * (endFirstLineY2 - startFirstLineY1));

            //double fsecondHypotenuseStart = Math.Abs(Math.Sqrt(Math.Pow(startSecondLineX1, 2) + Math.Pow(startSecondLineY1, 2)));
            //double secondHypotenuseStop = Math.Abs(Math.Sqrt(Math.Pow(endSecondLineX2, 2) + Math.Pow(endSecondLineY2, 2)));
            double secondLine = Math.Sqrt((endSecondLineX2 - startSecondLineX1) * (endSecondLineX2 - startSecondLineX1) +
                (endSecondLineY2 - startSecondLineY1) * (endSecondLineY2 - startSecondLineY1));

            string result = null;
            if (firstLine > secondLine)
            {
                result = CheckBigerOfTwoLines(startFirstLineX1,startFirstLineY1,endFirstLineX2,endFirstLineY2);
            }
            else if (secondLine > firstLine)
            {
                result = CheckBigerOfTwoLines(startSecondLineX1,startSecondLineY1,endSecondLineX2,endSecondLineY2);
            }
            else
            {
                result = $"({startFirstLineX1}, {startFirstLineY1})({endFirstLineX2}, {endFirstLineY2})";
            }
            
            return result;
        }

        static string CheckBigerOfTwoLines(double x1, double y1, double x2, double y2)
        {
            string result = null;
            double distance1 = Math.Sqrt(Math.Pow(x1, 2) + Math.Pow(y1, 2));
            double distance2 = Math.Sqrt(Math.Pow(x2, 2) + Math.Pow(y2, 2));
            if (distance1 < distance2)
            {
                result = $"({x1}, {y1})({x2}, {y2})";
            }
            else if (distance2 < distance1)
            {
                result = $"({x2}, {y2})({x1}, {y1})";
            }
            else
            {
                result = $"({x1}, {y1})({x2}, {y2})";
            }
            return result;
        }
    }
}
