using System;

namespace _01.CatDiet
{
    class Program
    {
        static void Main()
        {
            double fat = double.Parse(Console.ReadLine());
            double proteins = double.Parse(Console.ReadLine());
            double carbohydrates = double.Parse(Console.ReadLine());
            double calories = double.Parse(Console.ReadLine());
            double water = double.Parse(Console.ReadLine());

            double totalFat = fat * calories / 9 / 100.0;
            double totalProteins = proteins * calories / 4 / 100.0;
            double totalCarbohydrates = carbohydrates * calories / 4 / 100.0;
            double totalFood = totalFat + totalProteins + totalCarbohydrates;
            double caloriesPerGram = calories / totalFood;
            double waterPercentage = water / 100.0;
            double totalCalories = caloriesPerGram * (1 - waterPercentage);
            
            
            Console.WriteLine($"{totalCalories:f4}");

        }
    }
}
