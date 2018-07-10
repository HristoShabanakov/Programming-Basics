using System;

namespace _02.DeerOfSanta
{
    class Program
    {
        static void Main()
        {
            double days = double.Parse(Console.ReadLine());
            double food = double.Parse(Console.ReadLine());
            double foodPerDayFirstDeer = double.Parse(Console.ReadLine());
            double foodPerDaySecondDeer = double.Parse(Console.ReadLine());
            double foodPerDayThirdDeer = double.Parse(Console.ReadLine());

            double firstDeer = days * foodPerDayFirstDeer;
            double secondDeer = days * foodPerDaySecondDeer;
            double thirdDeer = days * foodPerDayThirdDeer;
            double totalFood = firstDeer + secondDeer + thirdDeer;

            if (food > totalFood)
            {
                Console.WriteLine($"{Math.Floor(food - totalFood)} kilos of food left.");
            }
            else
            {
                Console.WriteLine($"{Math.Ceiling(totalFood-food)} more kilos of food are needed.");
            }

        }
    }
}
