using System;

namespace _01.TailoringWorkshop
{
    class Program
    {
        static void Main()
        {
            double rectangularTables = double.Parse(Console.ReadLine());
            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());

            double area = rectangularTables * (length + 2 * 0.3) * (width + 2 * 0.3);
            double totalArea = rectangularTables * (length / 2) * (length / 2);
            double priceInUSD = (area * 7) + (totalArea * 9);
            double priceInBG = priceInUSD * 1.85;
            
            Console.WriteLine($"{priceInUSD:f2} USD");
            Console.WriteLine($"{priceInBG:f2} BGN");
        }
    }
}
