using System;

namespace _10.Balls
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int pointsFromRedBalls = 0;
            int pointsFromOrangeBalls = 0;
            int pointsFromYellowBalls = 0;
            int pointsFromWhiteBalls = 0;
            int dividesFromBlackBalls = 0;
            int otherColorsPicked = 0;
            int totalPoints = 0;

            for (int i = 0; i < n; i++)
            {
                string colorsInput = Console.ReadLine();
                switch (colorsInput)
                {
                    case "red":
                        totalPoints += 5;
                        pointsFromRedBalls++;
                        break;
                    case "orange":
                        totalPoints+= 10;
                        pointsFromOrangeBalls++;
                        break;
                    case "yellow":
                        totalPoints += 15;
                        pointsFromYellowBalls++;
                        break;
                    case "white":
                        totalPoints += 20;
                        pointsFromWhiteBalls++;
                        break;
                    case "black":
                        totalPoints /= 2;
                        dividesFromBlackBalls++;
                        break;
                    default:
                        otherColorsPicked++;
                        break;

                }
            }
            Console.WriteLine($"Total points: {totalPoints}");
            Console.WriteLine($"Points from red balls: {pointsFromRedBalls}");
            Console.WriteLine($"Points from orange balls: {pointsFromOrangeBalls}");
            Console.WriteLine($"Points from yellow balls: {pointsFromYellowBalls}");
            Console.WriteLine($"Points from white balls: {pointsFromWhiteBalls}");
            Console.WriteLine($"Other colors picked: {otherColorsPicked}");
            Console.WriteLine($"Divides from black balls: {dividesFromBlackBalls}");
        }
    }
}
