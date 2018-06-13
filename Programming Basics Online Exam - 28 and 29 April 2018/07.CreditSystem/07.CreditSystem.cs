using System;

namespace _07.CreditSystem
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            double credits = 0;
            double grades = 0;

            for (int i = 0; i < n; i++)
            {
                int input = int.Parse(Console.ReadLine());

                int currentCredits = input / 10;
                int grade = input % 10;

                switch (grade)
                {
                    case 2:
                        grades += 2;
                        break;
                    case 3:
                        credits += 0.5 * currentCredits;
                        grades += 3;
                        break;
                    case 4:
                        credits += 0.7 * currentCredits;
                        grades += 4;
                        break;
                    case 5:
                        credits += 0.85 * currentCredits;
                        grades += 5;
                        break;
                    case 6:
                        credits += currentCredits;
                        grades += 6;
                        break;
                }
            }
            Console.WriteLine($"{credits:f2}");
            Console.WriteLine($"{grades / n:f2}");
        }
    }
}
