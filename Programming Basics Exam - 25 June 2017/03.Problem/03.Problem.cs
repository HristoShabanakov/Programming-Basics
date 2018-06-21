using System;

namespace _03.Problem
{
    class Program
    {
        static void Main()
        {
            string fruit = Console.ReadLine();
            string size = Console.ReadLine();
            double numberOfCocktails = double.Parse(Console.ReadLine());
            double price = 0;

            switch (fruit)
            {
                case "Watermelon":
                    if (size == "small")
                        price += 56 * 2 * numberOfCocktails;
                    else
                        price += 28.70 * 5 * numberOfCocktails;
                    break;

                case "Mango":
                    if (size == "small")
                        price += 36.66 * 2 * numberOfCocktails;
                    else
                        price += 19.60 * 5 * numberOfCocktails;
                    break;

                case "Pineapple":
                    if (size == "small")
                        price += 42.10 * 2 * numberOfCocktails;
                    else
                        price += 24.80 * 5 * numberOfCocktails;
                    break;

                case "Raspberry":
                    if (size == "small")
                        price += 20 * 2 * numberOfCocktails;
                    else
                        price += 15.20 * 5 * numberOfCocktails;
                    break;
            }

            if (price > 1000)
            {
                price = price - (price * 0.50);
            }
            else if(price >=400 || price >=1000)
            {
                price = price - (price * 0.15);
            }

            Console.WriteLine($"{price:f2} lv.");
        }
    }
}
