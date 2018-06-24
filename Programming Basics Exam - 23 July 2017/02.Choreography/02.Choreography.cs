using System;

namespace _02.Choreography
{
    class Program
    {
        static void Main()
        {
            double steps = double.Parse(Console.ReadLine());
            double dancers = double.Parse(Console.ReadLine());
            double days = double.Parse(Console.ReadLine());

            double stepsPerDay = Math.Ceiling((steps / days) / steps * 100);
            double stepsPerDancer = stepsPerDay / dancers;

            if (stepsPerDay <= 13)
            {
                Console.WriteLine($"Yes, they will succeed in that goal! {stepsPerDancer:f2}%.");
            }
            else
            {
                Console.WriteLine($"No, They will not succeed in that goal! Required {stepsPerDancer:f2}% steps to be learned per day.");
            }
        }
    }
}
