using System;

namespace _02.Scholarship
{
    class Program
    {
        static void Main()
        {
            double income = double.Parse(Console.ReadLine());
            double averageGrade = double.Parse(Console.ReadLine());
            double minimumSalary = double.Parse(Console.ReadLine());

            //The operator ?: has the following syntax: operand1 ? operand2 : operand3
            //It works like this: if operand1 is set to true, the operator returns as a result operand2.
            //Otherwise (if operand1 is set to false), the operator returns as a result operand3.
            //During the execution, the value of the first argument is calculated. 
            //If it has value true, then the second (middle) argument is calculated and it is returned as a result.
            //However, if the calculated result of the first argument is false, then the third (last) argument is calculated and it is returned as a result.
            double socialScholarship = averageGrade > 4.5 && income < minimumSalary ? 0.35 * minimumSalary : 0;
            double excellentScholarship = averageGrade >= 5.5 ? averageGrade * 25 : 0;

            if (socialScholarship == 0 && excellentScholarship == 0)
                Console.WriteLine("You cannot get a scholarship!");
            else if (socialScholarship > excellentScholarship)
                Console.WriteLine($"You get a Social scholarship {Math.Floor(socialScholarship)} BGN");
            else
                Console.WriteLine($"You get a scholarship for excellent results {Math.Floor(excellentScholarship)} BGN");
        }
    }
}
