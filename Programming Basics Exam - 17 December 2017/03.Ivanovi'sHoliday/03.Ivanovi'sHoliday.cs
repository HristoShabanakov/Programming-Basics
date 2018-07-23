using System;

namespace _03.Ivanovi_sHoliday
{
    class Program
    {
        static void Main()
        {
            double nights = double.Parse(Console.ReadLine());
            string destination = Console.ReadLine();
            string transportation = Console.ReadLine();
            double price = 0;
            double voyage = 0;

            switch (destination)
            {
                case "Miami":
                    if (nights == 1 || nights <= 10)
                    {
                        price += nights * (2 * 24.99 + 3 * 14.99);
                        price = price + (price * 0.25);
                    }
                    
                    else if (nights==11 || nights <= 15)
                    {
                        price += nights * (2 * 22.99 + 3 * 11.99);
                        price = price + (price * 0.25);
                    }
                    else if (nights > 15)
                    {
                        price += nights * (2 * 20 + 3 * 10);
                        price = price + (price * 0.25);
                    }
                    break;

                case "Canary Islands":
                    if (nights == 1 || nights <= 10)
                    {
                        price += nights * (2 * 32.50 + 3 * 28.50);
                        price = price + (price * 0.25);
                    }

                    else if (nights == 11 || nights <= 15)
                    {
                        price += nights * (2 * 30.50 + 3 * 25.60);
                        price = price + (price * 0.25);
                    }
                    else if (nights > 15)
                    {
                        price += nights * (2 * 28 + 3 * 22);
                        price = price + (price * 0.25);
                    }
                    break;

                case "Philippines":
                    if (nights == 1 && nights <= 10)
                    {
                        price += nights * (2 * 42.99 + 3 * 39.99);
                        price = price + (price * 0.25);
                    }

                    else if (nights == 11 || nights <= 15)
                    {
                        price += nights * (2 * 41 + 3 * 36);
                        price = price + (price * 0.25);
                    }
                    else if (nights > 15)
                    {
                        price += nights * (2 * 38.5 + 3 * 32.40);
                        price = price + (price * 0.25);
                    }
                    break;
            }

            if (transportation == "train")
            {
                voyage += (2 * 22.30) + (3 * 12.5);
            }
            else if (transportation == "bus")
            {
                voyage += (2 * 45) + (3 * 37);
            }
            else if (transportation == "airplane")
            {
                voyage += (2 * 90) + (3 * 68.50);
            }

            double total = price + voyage;

            Console.WriteLine($"{total:f3}");
        }
    }
}
