using System;

namespace _01.Sandbox
{
    class Program
    {
        static void Main()
        {
            double height = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double sand = double.Parse(Console.ReadLine());
            double wood = double.Parse(Console.ReadLine());

            double area = height * width;
            double sandstoneArea = (height - (0.2 + 0.2)) * (width - (0.2 + 0.2));
            double curbStoneArea = area - sandstoneArea;
            double sandKg = Math.Ceiling(sandstoneArea * 20);
            double woodMeters = Math.Ceiling(curbStoneArea / (2.2 * 0.2));

            double sandPrice = sandKg * sand;
            double woodPrice = woodMeters * wood;
            double totalPrice = sandPrice + woodPrice;

            Console.WriteLine($"{totalPrice:f2}");
            
        }
    }
}
