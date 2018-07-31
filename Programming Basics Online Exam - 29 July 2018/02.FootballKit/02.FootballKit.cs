using System;

namespace _02.FootballKit
{
    class Program
    {
        static void Main()
        {
            double tshirtPrice = double.Parse(Console.ReadLine());
            double sum = double.Parse(Console.ReadLine());

            double shortsPrice = tshirtPrice * 0.75;
            double socksPrice = shortsPrice * 0.2;
            double shoesPrice = (tshirtPrice + shortsPrice) * 2;
            double totalPrice = tshirtPrice + shortsPrice + socksPrice + shoesPrice;
            double priceAfterDiscount = totalPrice - (totalPrice * 0.15);

            if (priceAfterDiscount >= sum)
            {
                Console.WriteLine("Yes, he will earn the world-cup replica ball!");
                Console.WriteLine($"His sum is {priceAfterDiscount:f2} lv.");
            }
            else
            {
                Console.WriteLine("No, he will not earn the world-cup replica ball.");
                Console.WriteLine($"He needs {sum - priceAfterDiscount:f2} lv. more.");
            }
        }
    }
}
