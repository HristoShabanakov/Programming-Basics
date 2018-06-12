using System;

namespace _03.CalorieCalculator
{
    class Program
    {
        static void Main()
        {
            char gender = char.Parse(Console.ReadLine());
            double weight = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double age = double.Parse(Console.ReadLine());
            string physicalActivity = Console.ReadLine();

            double heightInCm = height * 100;
            double bmr = 0;
           
            if (gender == 'm')
            {
                bmr = 66 + (13.7 * weight) + (5 * heightInCm) - (6.8 * age);

            }
            else if (gender == 'f')
            {
                bmr = 655 + (9.6 * weight) + (1.8 * heightInCm) - (4.7 * age);
            }

            if (physicalActivity == "sedentary")
            {
                bmr *= 1.2;
            }

            else if(physicalActivity == "lightly active")
            {
                bmr *= 1.375;
            }

            else if(physicalActivity == "moderately active")
            {
                bmr *= 1.55;
            }

            else if(physicalActivity == "very active")
            {
                bmr *= 1.725;
            }
               
             Console.WriteLine($"To maintain your current weight you will need {Math.Ceiling(bmr)} calories per day.");
        }
    }
}
