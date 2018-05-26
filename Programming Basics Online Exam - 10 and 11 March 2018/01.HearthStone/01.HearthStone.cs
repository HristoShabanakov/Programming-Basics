using System;

namespace _01.HearthStone
{
    class Program
    {
        static void Main()
        {
            int pauseTime = int.Parse(Console.ReadLine());
            double packetPrice = double.Parse(Console.ReadLine());
            double questPrice = double.Parse(Console.ReadLine());
            double coffeePrice = double.Parse(Console.ReadLine());

            int restingTime = 10;
            int breakTime = pauseTime - 5;
            int totalTime = breakTime - restingTime;
            double totalPackets = 3 * packetPrice;
            double totalQuests = 2 * questPrice;
            double total = totalPackets + totalQuests + coffeePrice;

            Console.WriteLine($"{total:F2}");
            Console.WriteLine($"{totalTime}");
        }
    }
}
