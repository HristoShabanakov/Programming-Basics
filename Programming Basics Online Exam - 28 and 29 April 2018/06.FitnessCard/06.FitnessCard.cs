using System;

namespace _06.FitnessCard
{
    class Program
    {
        static void Main()
        {
            double money = double.Parse(Console.ReadLine());
            char gender = char.Parse(Console.ReadLine());
            int age = int.Parse(Console.ReadLine());
            string sport = Console.ReadLine();

            double sum = 0;
            // The age must be between 5 and 105 and the money between 10 and 1000!
            if ((age >= 5 && age <= 105) && (money >= 10 && money < 1000))
            {
                if (gender == 'm')
                {
                    switch (sport)
                    {
                        case "Gym":
                            sum = 42;
                            break;
                        case "Boxing":
                            sum = 41;
                            break;
                        case "Yoga":
                            sum = 45;
                            break;
                        case "Zumba":
                            sum = 34;
                            break;
                        case "Dances":
                            sum = 51;
                            break;
                        case "Pilates":
                            sum = 39;
                            break;
                    }
                }
                else if (gender == 'f')
                {
                    switch (sport)
                    {
                        case "Gym":
                            sum = 35;
                            break;
                        case "Boxing":
                            sum = 37;
                            break;
                        case "Yoga":
                            sum = 42;
                            break;
                        case "Zumba":
                            sum = 31;
                            break;
                        case "Dances":
                            sum = 53;
                            break;
                        case "Pilates":
                            sum = 37;
                            break;
                    }
                }
                //All students cards under age of 19 (included) get 20 % discount.
                if (age <= 19)
                {
                    sum = sum - (sum * 0.2);
                }

                if (sum <= money)
                {
                    Console.WriteLine($"You purchased a 1 month pass for {sport:f2}.");
                }
                else
                {
                    Console.WriteLine($"You don't have enough money! You need ${sum - money:f2} more.");
                }
            }
        }
    }
}