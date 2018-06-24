using System;

namespace _03.FinalCompetition
{
    class Program
    {
        static void Main()
        {
            double countDancers = double.Parse(Console.ReadLine());
            double points = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string location = Console.ReadLine();

            double money = 0;
            double moneyAfterExpenses = 0;


            switch (location)
            {
                case "Bulgaria":
                    money += countDancers * points;
                    if (season == "winter")
                        moneyAfterExpenses = money - (money * 0.08);
                    else if (season == "summer")
                        moneyAfterExpenses = money - (money * 0.05);
                    break;

                case "Abroad":
                    money += (countDancers * points);
                    money = money + (money * 0.50);
                    if (season == "summer")
                        moneyAfterExpenses = money - (money * 0.10);
                    else if (season == "winter")
                        moneyAfterExpenses = money - (money * 0.15);
                    break;
            }
            double moneyForCharity = moneyAfterExpenses * 0.75;
            double leftMoney = moneyAfterExpenses - moneyForCharity;
            double moneyForDancers = leftMoney / countDancers;

            Console.WriteLine($"Charity - {moneyForCharity:f2}");
            Console.WriteLine($"Money per dancer - {moneyForDancers:f2}");
        }
    }
}
