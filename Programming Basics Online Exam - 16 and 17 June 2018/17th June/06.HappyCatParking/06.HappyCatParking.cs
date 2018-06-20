using System;

namespace _06.HappyCatParking
{
    class Program
    {
        static void Main()
        {
            int days = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            double totalSum = 0;
            double currentSum = 0;


            for (int daysCount = 1; daysCount <= days; daysCount++)
            {
                for (int hoursCount = 1; hoursCount <= hours; hoursCount++)
                {
                    //Even day & odd hour.
                    if (daysCount % 2 == 0 && hoursCount % 2 != 0)
                    {
                        totalSum += 2.5;
                        currentSum += 2.5;
                    }
                    //Odd day & even hour.
                    else if (daysCount % 2 != 0 && hoursCount % 2 == 0)
                    {
                        totalSum += 1.25;
                        currentSum += 1.25;
                    }
                    else
                    {
                        totalSum += 1;
                        currentSum += 1;
                    }
                }
                Console.WriteLine($"Day: {daysCount} - {currentSum:f2} leva");
                currentSum = 0;
            }
            Console.WriteLine($"Total: {totalSum:f2}");
        }
    }
}
