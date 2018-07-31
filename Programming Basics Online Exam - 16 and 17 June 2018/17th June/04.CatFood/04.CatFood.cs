using System;

namespace _04.CatFood
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int firstGroup = 0;
            int secondGroup = 0;
            int thirdGroup = 0;
            double totalCatFood = 0;

            for (int i = 1; i <= n; i++)
            {
                double input = double.Parse(Console.ReadLine());
                totalCatFood += input;

                if (input >= 100 && input < 200)
                {
                    firstGroup++;
                }
                else if (input >= 200 && input < 300)
                {
                    secondGroup++;
                }
                else if (input >= 300 && input < 400)
                {
                    thirdGroup++;
                }
            }

            Console.WriteLine($"Group 1: {firstGroup} cats.");
            Console.WriteLine($"Group 2: {secondGroup} cats.");
            Console.WriteLine($"Group 3: {thirdGroup} cats.");
            totalCatFood = Math.Round(((totalCatFood / 1000) * 12.45),2);
            Console.WriteLine($"Price for food per day: {totalCatFood} lv.");
        }
    }
}
