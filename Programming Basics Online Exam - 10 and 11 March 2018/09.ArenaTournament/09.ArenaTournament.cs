using System;

namespace _09.ArenaTournament
{
    class Program
    {
        static void Main()
        {
            double points = double.Parse(Console.ReadLine());
            string arena = Console.ReadLine();
            string days = Console.ReadLine();
            string items = Console.ReadLine();

            double totalPrice = 0;

            switch (items)
            {
                case "Poor":
                    totalPrice = 7000;
                    break;
                case "Normal":
                    totalPrice = 14000;
                    break;
                case "Legendary":
                    totalPrice = 21000;
                    break;
            }

            double discount = 0;

            if (arena == "Nangrand" && (days == "Monday" || days == "Wednesday"))
            {
                discount = 0.05;
            }

            else if (arena == "Gurubashi" && (days == "Tuesday" || days == "Thursday"))
            {
                discount = 0.10;
            }

            else if (arena == "Dire Maul" && (days == "Friday" || days == "Saturday"))
            {
                discount = 0.07;
            }

            totalPrice = totalPrice - (totalPrice * discount);

            double itemPrice = totalPrice / 5;

            int itemsBought = 0;

            for (int item = 1; item <=5 && points >= itemPrice; item++)
            {
                points -= itemPrice;
                itemsBought++;
            }


            if (itemsBought == 5)
            {
                Console.WriteLine($"Items bought: {itemsBought}");
                Console.WriteLine($"Arena points left: {points}");
                Console.WriteLine("Success!");
            }
            else
            {
                Console.WriteLine($"Items bought: {itemsBought}");
                Console.WriteLine($"Arena points left: {points}");
                Console.WriteLine("Failure!");
            }
        }
    }
}
