using System;

namespace _06.TheSongOfTheWheels
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int count = 0;
            string password = null;
            for (int a = 1; a <= 9; a++)
            {
                for (int b = 1; b <= 9; b++)
                {
                    for (int c = 1; c <= 9; c++)
                    {
                        for (int d = 1; d < 9; d++)
                        {
                            if (a < b && c > d )
                            {
                                int sum = a * b + c * d;
                                if (sum == n)
                                {
                                    Console.Write($"{a}{b}{c}{d} ");
                                    count++;
                                    if (count == 4)
                                    {
                                        password = $"{a}{b}{c}{d}";
                                    }
                                }
                            }
                        }
                    }
                }
            }
            if (count > 0)
                Console.WriteLine();
            if (password != null)
                Console.WriteLine($"Password: {password}");
            else
                Console.WriteLine("No!");
        }
    }
}
