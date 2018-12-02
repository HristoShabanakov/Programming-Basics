using System;

namespace _02.CatShirt
{
    class Program
    {
        static void Main(string[] args)
        {
            double sleeve = Math.Abs(double.Parse(Console.ReadLine()));
            double frontPart = Math.Abs(double.Parse(Console.ReadLine()));
            string material = Console.ReadLine();
            string tie = Console.ReadLine();

            double total = 0;
            double shirtPrice = sleeve * 2 + frontPart * 2;
            double totalShirtPrice = shirtPrice + (shirtPrice * 0.1);
            double totalShirt = totalShirtPrice / 100;

            if(material == "Linen")
            {
                total = totalShirt * 15 + 10;
            }
            else if(material== "Cotton")
            {
                total = totalShirt * 12 + 10;
            }
            else if(material== "Denim")
            {
                total = totalShirt * 20 + 10;
            }
            else if (material == "Twill")
            {
                total = totalShirt * 16 + 10;
            }
            else if (material == "Flannel")
            {
                total = totalShirt * 11 + 10;
            }
            
            if (tie == "Yes")
            {
                Console.WriteLine($"The price of the shirt is: {total + (total * 0.2):f2}lv.");
            }
            else
            {
                Console.WriteLine($"The price of the shirt is: {total:f2}lv.");
            }
            
        }
    }
}
