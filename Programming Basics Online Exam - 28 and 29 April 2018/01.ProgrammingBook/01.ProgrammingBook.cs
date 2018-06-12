using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            double singlePage = double.Parse(Console.ReadLine());
            double singleCover = double.Parse(Console.ReadLine());
            double discount = double.Parse(Console.ReadLine());
            double design = double.Parse(Console.ReadLine());
            double advanceMoney = double.Parse(Console.ReadLine());

            double preciseDiscount = discount / 100;
            double bookPrice = singlePage * 899 + singleCover * 2;
            double bookCost = bookPrice * (1 - preciseDiscount) + design;
            double preciseAdvance = advanceMoney / 100;
            double totalPrice = bookCost * (1 - preciseAdvance);


            Console.WriteLine($"Avtonom should pay {totalPrice:F2} BGN.");
        }
    }
}
