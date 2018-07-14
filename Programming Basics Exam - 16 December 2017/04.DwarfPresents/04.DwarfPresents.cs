using System;

namespace _04.DwarfPresents
{
    class Program
    {
        static void Main()
        {
            int dwarfs = int.Parse(Console.ReadLine());
            double money = double.Parse(Console.ReadLine());
            double budget = 0;

            for (int i = 0; i < dwarfs; i++)
            {
                string gifts = Console.ReadLine();
                if (gifts == "sand clock")
                    budget += 2.2;
                else if (gifts == "magnet")
                    budget += 1.5;
                else if (gifts == "cup")
                    budget += 5;
                else if (gifts == "t-shirt")
                    budget += 10;
            }
            if (money >= budget)
                Console.WriteLine($"Santa Claus has {money - budget:f2} more leva left! ");
            else
                Console.WriteLine($"Santa Claus will need {budget - money:f2} more leva. ");
        }
    }
}
