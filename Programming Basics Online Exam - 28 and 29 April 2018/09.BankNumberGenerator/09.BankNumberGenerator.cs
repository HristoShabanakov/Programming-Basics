using System;

namespace _09.BankNumberGenerator
{
    class Program
    {
        static void Main()
        {
            int firstRow = int.Parse(Console.ReadLine());
            char secondRow = char.Parse(Console.ReadLine().ToUpper());
            char thirdRow = char.Parse(Console.ReadLine().ToLower());
            char forthRow = char.Parse(Console.ReadLine().ToUpper());
            int fithRow = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            int count = 0;

            for (int i = firstRow; i <= 99; i++)
            {
                for (char j = secondRow; j <='Z' ; j++)
                {
                    for (char k = thirdRow; k <= 'z'; k++)
                    {
                        for (char l = forthRow; l <= 'Z'; l++)
                        {
                            for (int m = fithRow; m >= 10; m--)
                            {
                                if( i % 10== 2 && m % 10 == 5)
                                {
                                    count+=1;
                                }

                                if(count == n)
                                {
                                    Console.WriteLine($"{i}{j}{k}{l}{m}");
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
