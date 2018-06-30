using System;

namespace _01.Birthday
{
    class Program
    {
        static void Main(string[] args)
        {
            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double percentage = double.Parse(Console.ReadLine());

            double aquariumVolume = (length * width * height) * 0.001;
            double totalPercentage = percentage * 0.01;
            double totalLittersWater = aquariumVolume * (1 - totalPercentage);

            Console.WriteLine($"{totalLittersWater:f3}");
        }
    }
}
