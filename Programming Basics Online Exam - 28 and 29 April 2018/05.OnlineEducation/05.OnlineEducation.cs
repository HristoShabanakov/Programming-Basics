using System;

namespace _05.OnlineEducation
{
    class Program
    {
        static void Main()
        {
            string advanceSubscription = Console.ReadLine();
            int studentsAdvanceSubscription = int.Parse(Console.ReadLine());
            string normalSubscription = Console.ReadLine();
            int studentsNormalSubscription = int.Parse(Console.ReadLine());
            string lateSubscription = Console.ReadLine();
            int studentsLateSubscription = int.Parse(Console.ReadLine());

            
            int onlineStudents = 0;
            int onsiteStudents = 0;
            int totalStudents = 0;

            switch (advanceSubscription)
            {
                case "online":
                    onlineStudents += studentsAdvanceSubscription;
                    break;

                case "onsite":
                    onsiteStudents += studentsAdvanceSubscription;
                    break;
            }

            switch (normalSubscription)
            {
                case "online":
                    onlineStudents += studentsNormalSubscription;
                    break;
                case "onsite":
                    onsiteStudents += studentsNormalSubscription;
                    break;

            }
            switch (lateSubscription)
            {
                case "online":
                    onlineStudents += studentsLateSubscription;
                    break;

                case "onsite":
                    onsiteStudents += studentsLateSubscription;
                    break;
            }
           
            if(onsiteStudents > 600)
            {
                onlineStudents += onsiteStudents - 600;
                onsiteStudents = 600;
            }

            totalStudents = onlineStudents + onsiteStudents;

            Console.WriteLine($"Online students: {onlineStudents}");
            Console.WriteLine($"Onsite students: {onsiteStudents}");
            Console.WriteLine($"Total students: {totalStudents}");

        }
    }
}
