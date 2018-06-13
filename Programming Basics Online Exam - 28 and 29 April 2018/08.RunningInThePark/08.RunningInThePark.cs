using System;

namespace _08.RunningInThePark
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            double totalDistance = 0;
            double totalMinutes = 0;
            double totalCalories = 0;

            for (int i = 0; i < n; i++)
            {
                int minutes = int.Parse(Console.ReadLine());
                double distance = double.Parse(Console.ReadLine());
                string measure = Console.ReadLine();

                if (measure == "m")
                {
                    totalDistance += distance / 1000;
                    totalMinutes += minutes;
                    totalCalories += minutes / 20.0 * 400;
                }

                else if (measure == "km")
                {
                    totalDistance += distance;
                    totalMinutes += minutes;
                    totalCalories += minutes / 20.0 * 400;
                }
            }
            Console.WriteLine($"He ran {totalDistance:f2}km for {totalMinutes} minutes and burned {totalCalories} calories.");
        }
    }
}
