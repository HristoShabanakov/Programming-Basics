using System;

namespace _03.CourierExpress
{
    class Program
    {
        static void Main()
        {
            double weight = double.Parse(Console.ReadLine());
            string delivery = Console.ReadLine();
            double distance = double.Parse(Console.ReadLine());

            double totalWeight = weight * 1.000;
            double totalPrice = 0;
            double expressCost = 0;

            switch (delivery)
            {
                case "standard":
                    if (totalWeight < 1)
                    {
                        totalPrice += distance * 0.03;
                    }
                    else if (totalWeight == 1 || totalWeight <= 10)
                    {
                        totalPrice += distance * 0.05;
                    }

                    else if (totalWeight == 11 || totalWeight <= 40)
                    {
                        totalPrice += distance * 0.10;
                    }

                    else if (totalWeight == 41 || totalWeight <= 90)
                    {
                        totalPrice += distance * 0.15;
                    }
                    else if (totalWeight == 91 || totalWeight <= 150)
                    {
                        totalPrice += distance * 0.20;
                    }
                    break;

                case "express":
                    {
                        if (totalWeight < 1)
                        {
                            expressCost = weight * (0.03 * 0.80) * distance;
                            totalPrice += distance * 0.03 + expressCost;
                        }
                        else if (totalWeight == 1 || totalWeight <= 10)
                        {
                            expressCost = weight * (0.05 * 0.40) * distance;
                            totalPrice += distance * 0.05 + expressCost;
                        }

                        else if (totalWeight == 11 || totalWeight <= 40)
                        {
                            expressCost = weight * (0.10 * 0.05) * distance;
                            totalPrice += distance * 0.10 + expressCost;
                        }

                        else if (totalWeight == 41 || totalWeight <= 90)
                        {
                            expressCost = weight * (0.15 * 0.02) * distance;
                            totalPrice += distance * 0.15 + expressCost;
                        }
                        else if (totalWeight == 91 || totalWeight <= 150)
                        {
                            expressCost = weight * (0.20 * 0.01) * distance;
                            totalPrice += distance * 0.20 + expressCost;
                        }
                        break;
                    }
            }

            Console.WriteLine($"The delivery of your shipment with weight of {totalWeight:f3} kg. would cost {totalPrice:f2} lv.");
        }
    }
}
