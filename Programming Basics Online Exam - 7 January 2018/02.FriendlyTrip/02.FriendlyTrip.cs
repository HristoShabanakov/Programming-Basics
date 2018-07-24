using System;

namespace _02.FriendlyTrip
{
    class Program
    {
        static void Main()
        {
            double kilometers = double.Parse(Console.ReadLine());
            double fuel = double.Parse(Console.ReadLine());
            double fuelPrice = double.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());

            double fuelconsumption = (kilometers * fuel) / 100.0;
            double totalCost = fuelconsumption * fuelPrice;

            if (budget >= totalCost)
                Console.WriteLine($"You can take a trip. {budget - totalCost:f2} money left.");
            else
                Console.WriteLine($"Sorry, you cannot take a trip. Each will receive {budget / 5:f2} money.");
        }
    }
}
