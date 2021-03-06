﻿using System;

namespace _11.Convert_Speed_Units
{
    class Program
    {
        static void Main(string[] args)
        {
            int distanceInMeter = int.Parse(Console.ReadLine());
            byte hours = byte.Parse(Console.ReadLine());
            byte minutes = byte.Parse(Console.ReadLine());
            byte seconds = byte.Parse(Console.ReadLine());

            ushort time = (ushort)(hours * 3600 + minutes * 60 + seconds);
            float metersPerSecond = (float)distanceInMeter / time;
            float kilometersPerHour = ((float)distanceInMeter / 1000) / ((float)time / 3600);
            float milesPerHour = ((float)distanceInMeter / 1609) / ((float)time / 3600);

            Console.WriteLine("{0:0.#######}", metersPerSecond);
            Console.WriteLine("{0:0.#######}", kilometersPerHour);
            Console.WriteLine("{0:0.#######}", milesPerHour);
        }
    }
}
