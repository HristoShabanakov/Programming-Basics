using System;

namespace _01.WireNet
{
    class Program
    {
        static void Main()
        {
            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double price = double.Parse(Console.ReadLine());
            double weight = double.Parse(Console.ReadLine());

            double wireLength = 2 * length + 2 * width;
            double wirePrice = wireLength * price;
            double wireArea = wireLength * height;
            double wireWeight = wireArea * weight;

            Console.WriteLine($"{wireLength}");
            Console.WriteLine($"{wirePrice:f2}");
            Console.WriteLine($"{wireWeight:f3}");
        }
    }
}
