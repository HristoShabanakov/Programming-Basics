using System;

namespace _06.MultiplyTable
{
    class Program
    {
        static void Main()
        {
            double number = double.Parse(Console.ReadLine());
            //Example how to extract each digit of three digit number:
            //123 % 10 = 3
            double firstNumber = number % 10;
            //123 - 3 = 120 / 10 = 12
            double calculateSecondNumber = (number - firstNumber) / 10;
            //12 % 10 = 2
            double secondNumber = calculateSecondNumber % 10;
            //12 - 2 = 10 / 10 = 1
            double thirdNumber = (calculateSecondNumber - secondNumber) / 10;

            for (int firstDigit = 1; firstDigit <= firstNumber; firstDigit++)
            {
                for (int secondDigit = 1; secondDigit <= secondNumber; secondDigit++)
                {
                    for (int thirdDigit = 1; thirdDigit <= thirdNumber; thirdDigit++)
                    {
                        double result = firstDigit * secondDigit * thirdDigit;
                        Console.WriteLine($"{firstDigit} * {secondDigit} * {thirdDigit} = {result};");
                    }
                }
            }
        }
    }
}
   