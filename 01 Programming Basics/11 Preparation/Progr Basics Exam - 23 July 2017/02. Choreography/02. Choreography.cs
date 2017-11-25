using System;
namespace _02.Choreography
{
    class Program
    {
        static void Main(string[] args)
        {
            var countOfSteps = int.Parse(Console.ReadLine());
            var countOfDancers = int.Parse(Console.ReadLine());
            var countDaysForLearn = double.Parse(Console.ReadLine());

            var stepsForLearnToDay = Math.Ceiling((countOfSteps / countDaysForLearn) / countOfSteps * 100); // %
            var stepsForOneDancer = stepsForLearnToDay / countOfDancers; // %

            if (stepsForLearnToDay <= 13)
            {
                Console.WriteLine($"Yes, they will succeed in that goal! {stepsForOneDancer:F2}%.");
            }
            else
            {
                Console.WriteLine($"No, They will not succeed in that goal! Required" +
                    $" {stepsForOneDancer:F2}% steps to be learned per day.");
            }
        }
    }
}
