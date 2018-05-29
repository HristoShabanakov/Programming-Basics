using System;

namespace _06.Shopping
{
    class Program
    {
        static void Main()
        {
            double budget = double.Parse(Console.ReadLine());
            int chocoCount = int.Parse(Console.ReadLine());
            double milk = double.Parse(Console.ReadLine());

            double chocoPrice = chocoCount * 0.65;
            double milkPrice = milk * 2.7;
            double mandarineCount = Math.Floor(chocoCount - (chocoCount * 0.35));
            double mandarinePrice = mandarineCount * 0.20;
            double total = chocoPrice + milkPrice + mandarinePrice;

            if(total <= budget)
            {
                Console.WriteLine($"You got this, {budget-total:f2} money left!");
            }
            else
            {
                Console.WriteLine($"Not enough money, you need {total-budget:f2} more!");
            }
        }
    }
}
