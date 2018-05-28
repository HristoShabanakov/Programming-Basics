using System;

namespace _14.PrimePairs
{
    class Program
    {
        static void Main()
        {
            int firstPairOfNumbers = int.Parse(Console.ReadLine());
            int secondPairOfNumbers = int.Parse(Console.ReadLine());
            int startIndex = int.Parse(Console.ReadLine());
            int endIndex = int.Parse(Console.ReadLine());

            for (int firstTwoDigits = firstPairOfNumbers; firstTwoDigits <= firstPairOfNumbers + startIndex; firstTwoDigits++)
            {
                for (int secondTwoDigits = secondPairOfNumbers; secondTwoDigits <= secondPairOfNumbers + endIndex; secondTwoDigits++)
                {
                    bool isPrimeFirstNumber = true;

                    //Finding prime numbers
                    for (int k = 2; k <= Math.Floor(Math.Sqrt(firstTwoDigits)); k++)
                    {
                        if(firstTwoDigits % k == 0)
                        {
                            isPrimeFirstNumber = false;
                        }
                    }

                    bool isPrimeSecondNumber = true;

                    for (int l = 2; l <= Math.Floor(Math.Sqrt(secondTwoDigits)); l++)
                    {
                        if(secondTwoDigits % l == 0)
                        {
                            isPrimeSecondNumber = false;
                        }
                    }

                    if(isPrimeFirstNumber && isPrimeSecondNumber)
                    {
                        Console.WriteLine($"{firstTwoDigits}{secondTwoDigits}");
                    }
                }
            }
        }
    }
}
