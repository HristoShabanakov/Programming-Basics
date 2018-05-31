using System;

namespace _03
{
    class Program
    {
        static void Main(string[] args)
        {
            string gender = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            int yearsWork = int.Parse(Console.ReadLine());

            if (gender == "male")
            {
                int diffYears = Math.Abs(yearsWork - 38);
                int diffAge = Math.Abs(age - 64);

                if (age >= 64 && yearsWork >= 38)
                {
                    Console.WriteLine("Ready to retire at {0} and {1} years of experience!", age, yearsWork);
                }
                else if (age < 64 && yearsWork >= 38)
                {

                    Console.WriteLine("Worked enough, but not old enough. Years left to retirement: {0}.", diffAge);
                }
                else if (age >= 64 && yearsWork < 38)
                {

                    Console.WriteLine("Old enough, but haven't worked enough. Work experience left to retirement: {0}.", diffYears);
                }
                else
                {
                    Console.WriteLine("Too early. Years left to retirement: {0}. Work experience left to retirement: {1}.", diffAge, diffYears);
                }
            }
            else if (gender == "female")
            {
                int diffYears = Math.Abs(yearsWork - 35);
                int diffAge = Math.Abs(age - 61);

                if (age >= 61 && yearsWork >= 35)
                {
                    Console.WriteLine("Ready to retire at {0} and {1} years of experience!", age, yearsWork);
                }
                else if (age < 61 && yearsWork >= 35)
                {

                    Console.WriteLine("Worked enough, but not old enough. Years left to retirement: {0}.", diffAge);
                }
                else if (age >= 61 && yearsWork < 35)
                {

                    Console.WriteLine("Old enough, but haven't worked enough. Work experience left to retirement: {0}.", diffYears);
                }
                else
                {
                    Console.WriteLine("Too early. Years left to retirement: {0}. Work experience left to retirement: {1}.", diffAge, diffYears);
                }
            }
            else
            {
                Console.WriteLine("Invalid input.");
            }
        }
    }
}