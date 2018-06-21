using System;

namespace _04.Problem
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            double points = double.Parse(Console.ReadLine());
            int total = 0;
            int bonus = 0;

            for (int i = 1; i <= n; i++)
            {
                int input = int.Parse(Console.ReadLine());
                //For each even part bonus points * 2.
                if (i % 2 == 0)
                {
                    bonus += input * 2;
                }
                else
                {
                    total += input;
                }
            }
            double result = (bonus + total) * points;
            Console.WriteLine($"The project prize was {result:f2} lv.");
        }
    }
}
