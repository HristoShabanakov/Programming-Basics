using System;

namespace _07.SlotMachine
{
    class Program
    {
        static void Main()
        {
            char a = char.Parse(Console.ReadLine());
            int numberOne = int.Parse(Console.ReadLine());
            char b = char.Parse(Console.ReadLine());
            int numberTwo = int.Parse(Console.ReadLine());
            char c = char.Parse(Console.ReadLine());
            int numberThree = int.Parse(Console.ReadLine());

            int firstLetter = a + numberOne;
            int secondLetter = b + numberTwo;
            int thirdLetter = c + numberThree;

            Console.WriteLine($"{(char)firstLetter}{(char)secondLetter}{(char)thirdLetter}");

            if (firstLetter == '@' && secondLetter == '@' && thirdLetter == '@')
            {
                Console.WriteLine("!!! YOU LOSE EVERYTHING !!!");
            }
            else if (firstLetter == '7' && secondLetter == '7' && thirdLetter == '7')
            {
                Console.WriteLine("*** JACKPOT ***");
            }
        }
    }
}
