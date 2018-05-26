using System;

namespace _05.Illidan
{
    class Program
    {
        static void Main()
        {
            int count = int.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());
            int health = int.Parse(Console.ReadLine());
            int totalPower = count * power;

            if (totalPower < health)
            {
                Console.WriteLine($"You are not prepared! You need {health - totalPower} more points.");
            }
            else
            {
                Console.WriteLine($"Illidan has been slain! You defeated him with {totalPower - health} points.");
            }
        }
    }
}
