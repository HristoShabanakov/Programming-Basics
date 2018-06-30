using System;

namespace _06.Profit
{
    class Program
    {
        static void Main()
        {
            double coinsOneLv = double.Parse(Console.ReadLine());
            double coinsTwoLv = double.Parse(Console.ReadLine());
            double coinsThreeLv = double.Parse(Console.ReadLine());
            double sum = double.Parse(Console.ReadLine());

            for (int i = 0; i <= coinsOneLv; i++)
            {
                for (int j = 0; j <=coinsTwoLv; j++)
                {
                    for (int k = 0; k <=coinsThreeLv; k++)
                    {
                        if( i * 1 + j * 2 + k * 5 == sum)
                        {
                            Console.WriteLine($"{i} * 1 lv. + {j} * 2lv. + {k} * 5lv. = {sum} lv.");
                        }
                    }
                }
            }
        }
    }
}
