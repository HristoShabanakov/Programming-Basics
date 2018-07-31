using System;

namespace _03.FootballSouvenirs
{
    class Program
    {
        static void Main()
        {
            string country = Console.ReadLine();
            string souvenir = Console.ReadLine();
            double count = double.Parse(Console.ReadLine());
            double price = 0;

            switch (country)
            {
                case "Argentina":
                    if (souvenir == "flags")
                    {
                        price = 3.25;
                    }
                    else if (souvenir == "caps")
                    {
                        price = 7.20;
                    }
                    else if (souvenir == "posters")
                    {
                        price = 5.10;
                    }
                    else if (souvenir == "stickers")
                    {
                        price = 1.25;
                    }
                    break;

                case "Brazil":
                    if (souvenir == "flags")
                    {
                        price = 4.20;
                    }
                    else if (souvenir == "caps")
                    {
                        price = 8.50;
                    }
                    else if (souvenir == "posters")
                    {
                        price = 5.35;
                    }
                    else if (souvenir == "stickers")
                    {
                        price = 1.20;
                    }
                    break;

                case "Croatia":
                    if (souvenir == "flags")
                    {
                        price = 2.75;
                    }
                    else if (souvenir == "caps")
                    {
                        price = 6.90;
                    }
                    else if (souvenir == "posters")
                    {
                        price = 4.95;
                    }
                    else if (souvenir == "stickers")
                    {
                        price = 1.10;
                    }
                    break;

                case "Denmark":
                    if (souvenir == "flags")
                    {
                        price = 3.10;
                    }
                    else if (souvenir == "caps")
                    {
                        price = 6.50;
                    }
                    else if (souvenir == "posters")
                    {
                        price = 4.80;
                    }
                    else if (souvenir == "stickers")
                    {
                        price = 0.90;
                    }
                    break;
            }

            double totalPrice = count * price;

            if (country == "Argentina" || country == "Brazil" || country == "Croatia" || country == "Denmark" && souvenir == "flags"
                || souvenir == "caps" || souvenir == "posters" || souvenir == "stickers")
            {
                Console.WriteLine($"Pepi bought {count} {souvenir} of {country} for {totalPrice:f2} lv.");
            }
            else if (country != "Argentina" || country != "Brazil" || country != "Croatia" || country != "Denmark")
            {
                Console.WriteLine($"Invalid country!");
            }
            else if (souvenir != "flags" || souvenir != "caps" || souvenir != "posters" || souvenir != "stickers")
            {
                Console.WriteLine($"Invalid stockl!");
            }

        }
    }
}
