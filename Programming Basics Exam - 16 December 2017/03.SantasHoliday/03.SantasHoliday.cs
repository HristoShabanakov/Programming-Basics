using System;

namespace _03.SantasHoliday
{
    class Program
    {
        static void Main()
        {
            double stay = double.Parse(Console.ReadLine());
            string roomType = Console.ReadLine();
            string rating = Console.ReadLine();
            double price = 0;

            switch (roomType)
            {
                case "room for one person":
                    price += (stay - 1) * 18;
                    break;

                case "apartment":
                    price += (stay - 1) * 25;
                    if (stay < 10)
                        price = price - (price * 0.30);
                    else if (stay > 10 && stay < 15)
                        price = price - (price * 0.35);
                    else
                        price = price - (price * 0.50);
                    break;

                case "president apartment":
                    price += (stay - 1) * 35;
                    if (stay < 10)
                        price = price - (price * 0.10);
                    else if (stay > 10 && stay < 15)
                        price = price - (price * 0.15);
                    else
                        price = price - (price * 0.20);
                    break;
            }

            if (rating == "positive")
            {
                Console.WriteLine($"{price = price + (price * 0.25):f2}");
            }
            else if (rating == "negative")
            {
                Console.WriteLine($"{price = price - (price * 0.10):f2}");
            }
        }
    }
}

