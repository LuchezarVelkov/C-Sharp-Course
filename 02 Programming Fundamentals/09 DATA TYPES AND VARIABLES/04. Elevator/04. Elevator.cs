using System;

namespace _04.Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            double personCount = int.Parse(Console.ReadLine());
            double elevatorCapacity = int.Parse(Console.ReadLine());
            double fullCourses = personCount / elevatorCapacity;

            int total = (int)Math.Ceiling((double)personCount / elevatorCapacity);
            Console.WriteLine(total);

            //double personCount = int.Parse(Console.ReadLine());
            //double elevatorCapacity = int.Parse(Console.ReadLine());
            //double fullCourses = personCount / elevatorCapacity;
            //double notFullCourses = personCount % elevatorCapacity;
            //if (notFullCourses != 0)
            //{
            //    Console.WriteLine((int)fullCourses + 1);
            //}
            //else
            //{
            //    Console.WriteLine(fullCourses);
            //}
        }
    }
}
