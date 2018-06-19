using System;

namespace _06.RhombusOfStars
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var stars = 1;
            var spaces = n -1;
            //Draw top part
            for (int row = 0; row < n; row++)
            {
                for (int i = 0; i < spaces; i++)
                {
                    Console.Write(" ");
                }
                Console.Write("*");
                for (int i = 0; i < stars - 1; i++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
                stars++;
                spaces--;
            }
            //Draw down part
            spaces = 1;
            stars = n-1;
            for (int row = 0; row < n-1; row++)
            {
                for (int i = 0; i < spaces; i++)
                {
                    Console.Write(" ");
                }
                Console.Write("*");
                for (int i = 0; i < stars - 1; i++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
                stars--;
                spaces++;
            }

        }
    }
}
