using System;

namespace _02.PCStore
{
    class Program
    {
        static void Main()
        {
            double cpuPrice = double.Parse(Console.ReadLine());
            double videoCardPrice = double.Parse(Console.ReadLine());
            double ramMemory = double.Parse(Console.ReadLine());
            int ram = int.Parse(Console.ReadLine());
            double discount = double.Parse(Console.ReadLine());

            double cpuPriceBG = cpuPrice * 1.57;
            double videoCardBG = videoCardPrice * 1.57;
            double ramMemoryBG = ramMemory * 1.57;
            double totalRamMemory = ramMemoryBG * ram;
            double cpuPriceWithDiscount = cpuPriceBG - (cpuPriceBG * discount);
            double videoCardPriceWithDiscount = videoCardBG - (videoCardBG * discount);
            double total = cpuPriceWithDiscount + videoCardPriceWithDiscount + totalRamMemory;

            Console.WriteLine($"Money needed - {total:f2} leva.");
        }
    }
}
