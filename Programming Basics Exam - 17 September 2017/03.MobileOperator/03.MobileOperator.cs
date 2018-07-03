using System;

namespace _03.MobileOperator
{
    class Program
    {
        static void Main()
        {
            string contract = Console.ReadLine();
            string typeOfContract = Console.ReadLine();
            string internet = Console.ReadLine();
            int months = int.Parse(Console.ReadLine());

            double price = 0;
           
            switch (contract)
            {
                case "one":
                    if (typeOfContract == "Small")
                        price += 9.98;
                    else if (typeOfContract == "Middle")
                        price += 18.99;
                    else if (typeOfContract == "Large")
                        price += 25.98;
                    else if (typeOfContract == "ExtraLarge")
                        price += 35.99;
                    break;

                case "two":
                    if (typeOfContract == "Small")
                        price += 8.58;
                    else if (typeOfContract == "Middle")
                        price += 17.09;
                    else if (typeOfContract == "Large")
                        price += 23.59;
                    else if (typeOfContract == "ExtraLarge")
                        price += 31.79;
                    break;
            }
            
            switch (internet)
            {
                case "yes":
                    if (internet == "yes" && price <= 10)
                        price += 5.5;
                    else if (internet == "yes" && price <= 30)
                        price += 4.35;
                    else if (internet == "yes" && price > 30)
                        price += 3.85;
                    break;
            }
            if (contract == "two")
                price *= 1 - 0.0375;
            Console.WriteLine($"{price * months:f2} lv.");
        }
    }
}
