using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.GroupStage
{
    class Program
    {
        static void Main()
        {
            string country = Console.ReadLine();
            double matches = double.Parse(Console.ReadLine());
            double wins = 0;
            double draws = 0;
            double goalsDifference = 0;
            double scored = 0;
            double received = 0;

            for (int i = 0; i < matches; i++)
            {
                double scoredGoals = double.Parse(Console.ReadLine());
                double receivedGoals = double.Parse(Console.ReadLine());

                if (scoredGoals > receivedGoals)
                {
                    wins += 3;
                    scored += scoredGoals;
                    received += receivedGoals;
                    //goalsDifference += scoredGoals - receivedGoals;
                }
                else if (scoredGoals == receivedGoals)
                {
                    draws += 1;
                    scored += scoredGoals;
                    received += receivedGoals;
                    //goalsDifference += scoredGoals - receivedGoals;
                }
                else if (scoredGoals < receivedGoals)
                {
                    scored += scoredGoals;
                    received += receivedGoals;
                    //goalsDifference += scoredGoals - receivedGoals;
                }
            }
            double points = wins + draws;

            if (scored >= received)
            {
                Console.WriteLine($"{country} has finished the group phase with {points} points.");
                Console.WriteLine($"Goal difference: {scored-received}.");
            }
            else
            {
                Console.WriteLine($"{country} has been eliminated from the group phase.");
                Console.WriteLine($"Goal difference: {scored - received}.");
            }

            //Console.WriteLine($"{points} points");
            //Console.WriteLine($"{goalsDifference} goals");
        }
    }
}
