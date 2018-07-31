using System;

namespace _01.StadiumIncome
{
    class Program
    {
        static void Main()
        {
            double sectors = double.Parse(Console.ReadLine());
            double capacity = double.Parse(Console.ReadLine());
            double ticketPrice = double.Parse(Console.ReadLine());

            double incomePerSector = (capacity * ticketPrice) / sectors;
            double totalIncome = incomePerSector * sectors;
            double moneyForCharity = (totalIncome - (incomePerSector * 0.75)) / 8;

            Console.WriteLine($"Total income - {totalIncome:f2} BGN");
            Console.WriteLine($"Money for charity - {moneyForCharity:f2} BGN");
        }
    }
}
