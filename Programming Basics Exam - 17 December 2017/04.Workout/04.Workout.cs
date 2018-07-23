using System;

namespace _04.Workout
{
    class Program
    {
        static void Main()
        {
            double days = double.Parse(Console.ReadLine());
            double kilometers = double.Parse(Console.ReadLine());
            double totalKm = kilometers;
            
            for (int i = 0; i < days; i++)
            {
                double percentage = double.Parse(Console.ReadLine());
                kilometers *= 1 + percentage / 100;
                totalKm += kilometers;
            }

            if (totalKm <= 1000)
            {
                Console.WriteLine($"Sorry Mrs. Ivanova, you need to run {Math.Ceiling(1000- totalKm)} more kilometers");
            }
            else
            {
                Console.WriteLine($"You've done a great job running {Math.Ceiling(totalKm -1000)} more kilometers!");
            }
        }
    }
}
