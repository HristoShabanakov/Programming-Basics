using System;

namespace _06.BarcodeGenerator
{
    class Program
    {
        static void Main()
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            //Finding the first digit of the first number example: 2345 - the first digit is 2.
            int digitOne = firstNumber / 1000;
            int digitTwo = (firstNumber / 100) % 10;
            int digitThree = (firstNumber / 10) % 10;
            int digitFour = firstNumber % 10;

            int digitFive = secondNumber / 1000;
            int digitSix = (secondNumber / 100) % 10;
            int digitSeven = (secondNumber / 10) % 10;
            int digitEight = secondNumber % 10;

            for (int i = digitOne; i <= digitFive; i++)
            {
                for (int j = digitTwo; j <= digitSix; j++)
                {
                    for (int k = digitThree; k <= digitSeven; k++)
                    {
                        for (int l = digitFour; l <= digitEight; l++)
                        {
//We check if in the intervals between the numbers are any even numbers, if they are we ignore them and print the odd ones.
                            if (i % 2 != 0 && j % 2 != 0 && k % 2 != 0 && l % 2 != 0)
                            {
                                Console.Write($"{i}{j}{k}{l} ");
                            }
                        }
                    }
                }
            }
        }
    }
}
