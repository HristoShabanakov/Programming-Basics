using System;

namespace _05.CatFoodMeow
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            Console.Write("{0}{1}", new string('.', n - 1), new string('|', 1));
            for (int i = 1; i <= n; i++)
            {
                Console.Write("\\/");
            }
            Console.WriteLine("{1}{0}", new string('.', n - 1), new string('|', 1));

            Console.Write("{0}{1}", new string('.', n - 1), new string('|', 1));
            for (int i = 1; i <= 2 * n; i++)
            {
                Console.Write("~");
            }
            Console.WriteLine("{1}{0}", new string('.', n - 1), new string('|', 1));

            int space = 0;
            int count = n;
            for (int i = 1; i <= n; i++)
            {
                Console.Write("{0}{1}{2}", new string('.', n - 1), new string('|', 1), new string(' ', space));
                for (int j = 1; j <= count; j++)
                {
                    Console.Write("{}");
                }
                Console.Write("{2}{1}{0}", new string('.', n - 1), new string('|', 1), new string(' ', space));
                count--;
                space++;
                Console.WriteLine();
            }
            int space2 = n - 2;
            Console.WriteLine("{0}{1}{2}MEOW{2}{1}{0}", new string('.', n - 1), new string('|', 1), new string(' ', space2));
            Console.WriteLine("{0}{1}{2}FOOD{2}{1}{0}", new string('.', n - 1), new string('|', 1), new string(' ', space2));

            count = 1;
            space = n - 1;
            for (int i = 1; i <= n; i++)
            {
                Console.Write("{0}{1}{2}", new string('.', n - 1), new string('|', 1), new string(' ', space));
                for (int j = 1; j <= count; j++)
                {
                    Console.Write("{}");
                }
                Console.Write("{2}{1}{0}", new string('.', n - 1), new string('|', 1), new string(' ', space));
                count++;
                space--;
                Console.WriteLine();
            }
            Console.Write("{0}{1}", new string('.', n - 1), new string('|', 1));
            for (int i = 1; i <= 2 * n; i++)
            {
                Console.Write("~");
            }
            Console.WriteLine("{1}{0}", new string('.', n - 1), new string('|', 1));
            Console.Write("{0}{1}", new string('.', n - 1), new string('|', 1));
            for (int i = 1; i <= n; i++)
            {
                Console.Write("\\/");
            }
            Console.WriteLine("{1}{0}", new string('.', n - 1), new string('|', 1));
        }
    }
}
