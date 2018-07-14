using System;

namespace _02.NewYearsEveParty
{
    class Program
    {
        static void Main()
        {
            double guests = double.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());

            double covert = guests * 20;
            double remainingMoney = budget - covert;

            if (budget >= covert)
            {
                double donationMoney = remainingMoney - (remainingMoney * 0.40);
                double fireworksMoney = remainingMoney - donationMoney;
                Console.WriteLine($"Yes! {Math.Round(fireworksMoney)} lv are for fireworks and {Math.Round(donationMoney)} lv are for donation.");
            }
            else if (budget < covert)
            {
                Console.WriteLine($"They won't have enough money to pay the covert. They will need {Math.Round(covert - budget)} lv more.");
            }
        }
    }
}
