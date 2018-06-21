using System;

namespace _02.Problem
{
    class Program
    {
        static void Main()
        {
            double record = double.Parse(Console.ReadLine());
            double distanceMeters = double.Parse(Console.ReadLine());
            double timeInSeconds = double.Parse(Console.ReadLine());

            double time = distanceMeters * timeInSeconds;
            double extraTime = (distanceMeters / 15);
            //Math Floor rounds down to the closest integer.
            double roundTime = Math.Floor(extraTime) * 12.5;
            double totalTime = time + roundTime;

            if (totalTime < record)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {totalTime:f2} seconds.");
            }
            else
            {
                Console.WriteLine($"No, he failed! He was {totalTime - record:f2} seconds slower.");
            }
        }
    }
}
