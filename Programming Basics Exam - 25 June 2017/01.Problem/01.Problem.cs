using System;

namespace _01.Problem
{
    class Program
    {
        static void Main()
        {
            double days = double.Parse(Console.ReadLine());
            double bakers = double.Parse(Console.ReadLine());
            double cakes = double.Parse(Console.ReadLine());
            double waffles = double.Parse(Console.ReadLine());
            double pancakes = double.Parse(Console.ReadLine());

            double cakePrice = cakes * 45;
            double wafflesPrice = waffles * 5.8;
            double pancakesPrice = pancakes * 3.2;

            double dailyIncome = (cakePrice + wafflesPrice + pancakesPrice) * bakers;
            double totalMoney = dailyIncome * days;

            double final = totalMoney - (totalMoney * 0.125);

            Console.WriteLine($"{final:f2}");
        }
    }
}
