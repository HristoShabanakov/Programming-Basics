using System;

namespace _02.SeaTrip
{
    class Program
    {
        static void Main()
        {
            double foodMoney = double.Parse(Console.ReadLine());
            double souvenirMoney = double.Parse(Console.ReadLine());
            double hotelMoney = double.Parse(Console.ReadLine());

            double totalDistance = 420.0 / 100.0 * 7 * 1.85;
            double foodAndSouvenirMoney = foodMoney * 3 + souvenirMoney * 3;
            double accommodationMoney = hotelMoney * 0.9 + hotelMoney * 0.85 + hotelMoney * 0.8;
            double totalMoneySpent = totalDistance + foodAndSouvenirMoney + accommodationMoney;
            

            Console.WriteLine($"Money needed: {totalMoneySpent:f2}");
        }
    }
}
