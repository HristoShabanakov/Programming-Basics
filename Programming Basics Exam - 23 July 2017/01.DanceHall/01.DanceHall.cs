using System;

namespace _01.DanceHall
{
    class Program
    {
        static void Main()
        {
            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double wardrobe = double.Parse(Console.ReadLine());

            double hallSize = (length * 100) * (width * 100);
            double wardrobeSize = (wardrobe * 100) * (wardrobe * 100);
            double benchSize = hallSize / 10;
            double freeSpace = hallSize - wardrobeSize - benchSize;
            double dancersCount = freeSpace / (40 + 7000);

            Console.WriteLine(Math.Floor(dancersCount));
        }
    }
}
