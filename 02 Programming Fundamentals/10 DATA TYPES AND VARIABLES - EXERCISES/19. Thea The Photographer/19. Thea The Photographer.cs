using System;

namespace _19.Thea_The_Photographer
{
    class Program
    {
        static void Main(string[] args)
        {
            double allTakenPictures = double.Parse(Console.ReadLine());
            double filterTimeForEachPicture = double.Parse(Console.ReadLine()); // second
            int aproovedPictures = int.Parse(Console.ReadLine()); // % of all pictures !! Round to upper
            double timeNeededToUploadPicture = double.Parse(Console.ReadLine()); // time for upload one picture

            double pictureToUpload = (allTakenPictures / 100.0) * aproovedPictures;
            double timeNeed = (allTakenPictures * filterTimeForEachPicture) + (Math.Ceiling(pictureToUpload) * timeNeededToUploadPicture);

            TimeSpan time = TimeSpan.FromSeconds(timeNeed);
            string timeInString = time.ToString(@"d\:hh\:mm\:ss");
            Console.WriteLine(timeInString);

            // The time for the loop is cutting the score :(

            //int day = 0;
            //int hour = 0;
            //int minutes = 0;
            //int seconds = 0;

            //for (int i = 1; i <= timeNeed; i++)
            //{
            //    seconds++;
            //    if (seconds == 60)
            //    {
            //        minutes++;
            //        seconds = 0;
            //        if (minutes == 60)
            //        {
            //            hour++;
            //            minutes = 0;
            //            if (hour == 24)
            //            {
            //                day++;
            //                hour = 0;
            //            }
            //        }
            //    }
            //}

            //Console.WriteLine($"{day}:{hour:D2}:{minutes:D2}:{seconds:D2}");
        }
    }
}
