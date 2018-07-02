using System;

namespace _04.GrandpaStavri
{
    class Program
    {
        static void Main()
        {
            double days = double.Parse(Console.ReadLine());
            double totalLitters = 0;
            double littersPerDay = 0;


            for (int i = 0; i < days; i++)
            {
                double quantity = double.Parse(Console.ReadLine());
                double degrees = double.Parse(Console.ReadLine());
                totalLitters += quantity;
                littersPerDay += quantity * degrees;
            }

            double totalDegrees = littersPerDay / totalLitters;

            Console.WriteLine($"Liter: {totalLitters:f2}");
            Console.WriteLine($"Degrees: {totalDegrees:f2}");

            if (totalDegrees < 38)
            {
                Console.WriteLine("Not good, you should baking!");
            }
            else if (totalDegrees > 38 && totalDegrees < 42)
            {
                Console.WriteLine("Super!");
            }
            else if (totalDegrees > 42)
            {
                Console.WriteLine("Dilution with distilled water!");
            }

        }
    }
}
