using System;

namespace _04.AnnualSalary
{
    class Program
    {
        static void Main()
        {
            int experience = int.Parse(Console.ReadLine());
            string proffession = Console.ReadLine();

            double monthlyIncome = 0;

            if (proffession == "C# Developer")
            {
                monthlyIncome = 5400;
            }

            else if (proffession == "Java Developer")
            {
                monthlyIncome = 5700;
            }

            else if (proffession == "Front-End Web Developer")
            {
                monthlyIncome = 4100;
            }

            else if (proffession == "UX / UI Designer")
            {
                monthlyIncome = 3100;
            }

            else if (proffession == "Game Designer")
            {
                monthlyIncome = 3600;
            }

            if (experience <= 5)
            {
                monthlyIncome -= monthlyIncome * 0.658;
            }

            double totalMoney = 12 * monthlyIncome;
            Console.WriteLine($"Total earned money: {totalMoney:f2} BGN");
        }
    }
}
