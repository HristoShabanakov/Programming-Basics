using System;

namespace _06.LuckyNumbers
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j <= 9; j++)
                {
                    for (int k = 1; k <= 9; k++)
                    {
                        for (int l = 1; l <=9; l++)
                        {
                            int sumOne = i + j;
                            int sumTwo = k + l;
                
                            if (sumOne == sumTwo)
                            {
                         //N should be divided without remainder from the sum of the first two numbers.
                                if (n % sumOne == 0)
                                    Console.Write($"{i}{j}{k}{l} ");
                            }

                        }
                    }
                }
            }
        }
    }
}
