using System;

namespace _12.CSGO
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int ak47 = 2700;
            int awp = 4750;
            int sg553 = 3500;
            int grenade = 300;
            int flash = 250;
            int glock = 500;
            int bazooka = 5600;
            int total = 0;
            int itemsCount = 0;

            int money = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                 if (n > 7)
                {
                    Console.WriteLine("Sorry, you can't carry so many things!");
                    return;
                }

                string input = Console.ReadLine();

                switch (input)
                {
                    case "ak47":
                        total += 2700;
                        itemsCount++;
                        break;
                    case "awp":
                        total += 4750;
                        itemsCount++;
                        break;
                    case "sg553":
                        total += 3500;
                        itemsCount++;
                        break;
                    case "grenade":
                        total += 300;
                        itemsCount++;
                        break;
                    case "flash":
                        total += 250;
                        itemsCount++;
                        break;
                    case "glock":
                        total += 500;
                        itemsCount++;
                        break;
                    case "bazooka":
                        total += 5600;
                        itemsCount++;
                        break;
                }
            }

            if (money < total)
            {
                Console.WriteLine($"Not enough money! You need {total - money} more money.");

            }

            else
            {
                Console.WriteLine($"You bought all {itemsCount} items! Get to work and defeat the bomb!");
            }
        }
    }
}
