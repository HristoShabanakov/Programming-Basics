using System;

namespace _03.CatTrainingAttendance
{
    class Program
    {
        static void Main()
        {
            int start = int.Parse(Console.ReadLine());
            int presence = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            string day = Console.ReadLine();

            double bonusPoints = 0;

            if (day == "Monday" || day == "Wednesday" || day == "Friday")
            {
                bonusPoints += 0.6;
            }
            else if (day == "Tuesday" || day == "Thursday" || day == "Saturday")
            {
                bonusPoints += 0.8;
            }
            else if (day == "Sunday")
            {
                bonusPoints += 2;
            }

            if (start >= 17 && presence <= 18 && minutes > 00)
            {
                Console.WriteLine(bonusPoints += 1.5);
            }
            else if (start >= 18 && presence <= 18 && minutes > 30)
            {
                Console.WriteLine(bonusPoints += 1);
            }
            else if (start >= 18 && presence <= 22 && minutes > 00)
            {
                Console.WriteLine(bonusPoints += 0.5);
            }

            //Console.WriteLine($"{bonusPoints:f2}");
        }
    }
}
