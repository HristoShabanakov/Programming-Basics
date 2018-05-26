using System;

namespace _03.Travel
{
    class Program
    {
        static void Main()
        {
            double distance = double.Parse(Console.ReadLine());
            double truckSpeed = double.Parse(Console.ReadLine());
            double speedDifference = double.Parse(Console.ReadLine());
            double carSpeed = (speedDifference * 3.6) + truckSpeed;
            double truckTime = Math.Ceiling( distance / truckSpeed);
            double carTime = Math.Ceiling(distance / carSpeed);
            
            Console.WriteLine($"The truck arrived after {truckTime} hours");
            Console.WriteLine($"The car arrived after {carTime} hours");
        }
    }
}
