using System;

namespace _03.SquareOfStars
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int row = 1; row <=n; row++)
            {
                Console.Write("*");
                for (int col = 1; col < n; col++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }
        }
    }
}
