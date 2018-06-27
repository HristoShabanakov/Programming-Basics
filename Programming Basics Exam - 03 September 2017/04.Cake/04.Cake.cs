using System;

namespace _04.Cake
{
    class Program
    {
        static void Main()
        {
            double width = double.Parse(Console.ReadLine());
            double lenght = double.Parse(Console.ReadLine());
            double pieces = width * lenght;

            while (pieces >= 0)
            {
                string input = Console.ReadLine();
                if (input == "STOP")
                {
                    break;
                }
                //Everytime when someone take a piece of cake we reduce the total number if pieces.
                pieces -= int.Parse(input);
            }
            if (pieces >= 0)
            {
                Console.WriteLine($"{pieces} pieces are left.");
            }
            else
            {
                Console.WriteLine($"No more cake left! You need {Math.Abs(pieces)} pieces more.");
            }

        }
    }
}
