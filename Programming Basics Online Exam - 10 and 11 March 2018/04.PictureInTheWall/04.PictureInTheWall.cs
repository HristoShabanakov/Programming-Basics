using System;

namespace _04.PictureInTheWall
{
    class Program
    {
        static void Main()
        {
            int width = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());
            int side = int.Parse(Console.ReadLine());
            int picturesCount = int.Parse(Console.ReadLine());

            int holeArea = width * length;
            int picturesArea = (side * side) * picturesCount;

            if (holeArea < picturesArea)
            {
                Console.WriteLine($"The pictures don't fit in the hole. Picture area is {picturesArea - holeArea} bigger than hole area.");
            }
            else
            {
                Console.WriteLine($"The pictures fit in the hole. Hole area is {holeArea - picturesArea} bigger than pictures area.");
            }
        }
    }
}
