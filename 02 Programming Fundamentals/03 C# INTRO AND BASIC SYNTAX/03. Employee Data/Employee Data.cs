using System;

namespace _03.Employee_Data
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = Console.ReadLine();
            var age = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
            var employeeId = int.Parse(Console.ReadLine());
            var montlySalary = double.Parse(Console.ReadLine());
            Console.WriteLine("Name: {0}", name);
            Console.WriteLine("Age: {0}", age);
            Console.WriteLine("Employee ID: {0}", employeeId.ToString("D8"));
            Console.WriteLine("Salary: {0}", montlySalary.ToString("F2"));
            Console.WriteLine($"Salary: {montlySalary:F}");
        }
    }
}
