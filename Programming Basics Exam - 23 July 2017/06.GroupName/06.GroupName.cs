using System;

namespace _06.GroupName
{
    class Program
    {
        static void Main()
        {
            char a = char.Parse(Console.ReadLine().ToUpper());
            char b = char.Parse(Console.ReadLine().ToLower());
            char c = char.Parse(Console.ReadLine().ToLower());
            char d = char.Parse(Console.ReadLine().ToLower());
            int e = int.Parse(Console.ReadLine());

            int counter = 0;

            for (char i = 'A'; i <= a; i++)
            {
                for (char j = 'a'; j <= b; j++)
                {
                    for (char k = 'a'; k <= c; k++)
                    {
                        for (char l = 'a'; l <= d; l++)
                        {
                            for (int m = 0; m <= e; m++)
                            {
                                if (i == a && j == b && k == c && l == d && m == e)
                                {
                                    break;
                                }
                                counter++;
                            }
                        }
                    }
                }
            }
            Console.WriteLine(counter);
        }
    }
}
