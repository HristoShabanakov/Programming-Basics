using System;

namespace _01.ChristmasPreparation
{
    class Program
    {
        static void Main()
        {
            double rolls = double.Parse(Console.ReadLine());
            double cotton = double.Parse(Console.ReadLine());
            double glue = double.Parse(Console.ReadLine());
            double discount = double.Parse(Console.ReadLine());

            double rollsPrice = rolls * 5.8;
            double cottonPrice = cotton * 7.2;
            double gluePrice = glue * 1.2;
            double totalPrice = rollsPrice + cottonPrice + gluePrice;
            double discountPrice = totalPrice - ((totalPrice * discount) / 100);

            Console.WriteLine($"{discountPrice:f3}");
        }
    }
}
