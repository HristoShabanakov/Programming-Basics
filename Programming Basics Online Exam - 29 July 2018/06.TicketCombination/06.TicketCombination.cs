using System;

namespace _06.TicketCombination
{
    class Program
    {
        static void Main()
        {
            int input = int.Parse(Console.ReadLine());
            int counter = 0;

            for (char i = 'B'; i <= 'L'; i+=(char)2)
            {
                for (char j = 'f'; j >= 'a'; j--)
                {
                    for (char k = 'A'; k <= 'C'; k++)
                    {
                        for (int l = 1; l <= 10; l++)
                        {
                            for (int m = 10; m >= 1; m--)
                            {
                                counter++;
                                if(counter >=input)
                                {
                                    Console.WriteLine($"Ticket combination: {i}{j}{k}{l}{m}");
                                    int totalSum = i + j + k + l + m;
                                    Console.WriteLine($"Prize: {totalSum} lv.");
                                    return;
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
