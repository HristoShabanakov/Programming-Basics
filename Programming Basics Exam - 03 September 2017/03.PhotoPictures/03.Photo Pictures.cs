using System;

namespace _03.PhotoPictures
{
    class Program
    {
        static void Main()
        {
            double picturesCount = double.Parse(Console.ReadLine());
            string picturesType = Console.ReadLine();
            string orderType = Console.ReadLine();

            double price = 0;
            switch (picturesType)
            {
                case "9X13":
                    price += picturesCount * 0.16;
                    if (picturesCount >= 50)
                    {
                        price = price - (price * 0.05);
                    }
                    break;

                case "10X15":
                    price += picturesCount * 0.16;
                    if (picturesCount >= 80)
                    {
                        price = price - (price * 0.03);
                    }
                    break;
                case "13X18":
                    price += picturesCount * 0.38;
                    if (picturesCount >= 50 && picturesCount <= 100)
                    {
                        price = price - (price * 0.03);
                    }
                    else if (picturesCount > 100)
                    {
                        price = price - (price * 0.05);
                    }
                    break;
                case "20X30":
                    price += picturesCount * 2.9;
                    if (picturesCount >= 10 && picturesCount <= 50)
                    {
                        price = price - (price * 0.07);
                    }
                    else if (picturesCount > 50)
                    {
                        price = price - (price * 0.09);
                    }
                    break;
            }
            if (orderType == "online")
            {
                price = price - (price * 0.02);
                Console.WriteLine($"{price:f2}BGN");
            }
            else
            {
                Console.WriteLine($"{price:f2}BGN");
            }
        }
    }
}
