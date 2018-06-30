using System;

namespace _02.ThreeBrothers
{
    class Program
    {
        static void Main()
        {
            double firstBrother = double.Parse(Console.ReadLine());
            double secondBrother = double.Parse(Console.ReadLine());
            double thirdBrother = double.Parse(Console.ReadLine());
            double fatherFishingTime = double.Parse(Console.ReadLine());

            double cleaningTime = 1 / (1 / firstBrother + 1 / secondBrother + 1 / thirdBrother);
            double totalTime = cleaningTime + (cleaningTime * 0.15);
            double leftTime = (fatherFishingTime - totalTime);

            if (leftTime > 0)
            {
                Console.WriteLine($"Cleaning time: {totalTime:f2}");
                Console.WriteLine($"Yes, there is a surprise - time left -> {Math.Floor(leftTime)} hours.");
            }
            else
            {
                Console.WriteLine($"Cleaning time: {totalTime:f2}");
                Console.WriteLine($"No, there isn't a surprise - shortage of time -> {Math.Abs(Math.Floor(leftTime))} hours.");
            }
        }
    }
}
