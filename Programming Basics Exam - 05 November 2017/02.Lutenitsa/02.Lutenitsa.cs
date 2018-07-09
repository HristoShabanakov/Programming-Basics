using System;

namespace _02.Lutenitsa
{
    class Program
    {
        static void Main()
        {
            decimal tomatoes = decimal.Parse(Console.ReadLine());
            int boxes = int.Parse(Console.ReadLine());
            int jars = int.Parse(Console.ReadLine());

            decimal totalkgs = tomatoes / (decimal)5.0;
            decimal totalJars = totalkgs / (decimal)0.535;
            decimal totalBoxes = totalJars / jars;

            Console.WriteLine($"Total lutenica: {Math.Floor(totalkgs)} kilograms.");

            if (totalBoxes >= boxes)
            {
                Console.WriteLine($"{Math.Floor(totalBoxes - boxes)} boxes left.");
                Console.WriteLine($"{Math.Floor(totalJars - (boxes * jars))} jars left.");
            }
            else
            {
                Console.WriteLine($"{Math.Floor(boxes - totalBoxes)} more boxes needed.");
                decimal jarsLeft = (jars * boxes) - (totalJars);
                Console.WriteLine($"{Math.Floor(jarsLeft)} more jars needed.");
            }
        }
    }
}
