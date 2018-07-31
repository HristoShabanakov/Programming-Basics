using System;

namespace _05.GameInfo
{
    class Program
    {
        static void Main()
        {
            string country = Console.ReadLine();
            double matches = double.Parse(Console.ReadLine());
            double totalTime = 0;
            double extraTime = 0;
            double penalties = 0;

            for (int i = 0; i < matches; i++)
            {
                double minutes = double.Parse(Console.ReadLine());
                totalTime += minutes;
                if (minutes > 90 && minutes <= 120)
                {
                    extraTime++;
                }
                else if (minutes > 120)
                {
                    penalties++;
                }
            }

            Console.WriteLine($"{country} has played {totalTime} minutes. Average minutes per game: {totalTime / matches:f2}");
            Console.WriteLine($"Games with penalties: {penalties}");
            Console.WriteLine($"Games with additional time: {extraTime}");
        }
    }
}
