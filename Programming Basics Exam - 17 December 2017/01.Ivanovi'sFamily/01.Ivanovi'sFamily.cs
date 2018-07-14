using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Ivanovi_sFamily
{
    class Program
    {
        static void Main()
        {
            double budget = double.Parse(Console.ReadLine());
            double firstKidPrice = double.Parse(Console.ReadLine());
            double secondKidPrice = double.Parse(Console.ReadLine());
            double thirdKidPrice = double.Parse(Console.ReadLine());

            double totalKidsPrice = firstKidPrice + secondKidPrice + thirdKidPrice;
            double total = budget - totalKidsPrice;
            double donationAmount = total - (total * 0.10);
            Console.WriteLine(donationAmount);

        }
    }
}
