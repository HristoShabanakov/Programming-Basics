using System;

namespace _03.CatTrainingAttendance
{
    class Program
    {
        static void Main()
        {
            int hoursOfBeginning = int.Parse(Console.ReadLine());
            int hoursCheckIn = int.Parse(Console.ReadLine());
            int minutesCheckIn = int.Parse(Console.ReadLine());
            string day = Console.ReadLine();

            double bonusPoints = 0;

            if (day == "Monday" || day == "Wednesday" || day == "Friday")
                bonusPoints += 0.6;
            else if (day == "Tuesday" || day == "Thursday" || day == "Saturday")
                bonusPoints += 0.8;
            else if (day == "Sunday")
                bonusPoints += 2;

            //If the training starts at 17:00(included) until 18:00
            if (hoursCheckIn < hoursOfBeginning && hoursCheckIn <= (hoursOfBeginning - 1))
               bonusPoints += 1.5;
            //Starts at 18:00(included) until 18:30
            else if (hoursCheckIn == hoursOfBeginning && minutesCheckIn <= 30)
                bonusPoints += 1;
            //Starts at 18:30 until 22:30(included)
            else if (hoursCheckIn == hoursOfBeginning && minutesCheckIn > 30 || hoursCheckIn < (hoursOfBeginning + 4))
                bonusPoints += 0.5;

            Console.WriteLine($"{bonusPoints:f2}");
        }
    }
}
