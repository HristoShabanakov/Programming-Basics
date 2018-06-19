using System;

namespace _10.Diamond
{
    class Program
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            var mid = -1;
            if (n % 2 == 0)
            {
                mid = 0;
            }

            for (int i = 1; i <= (n+1) / 2; i++)
            {
                var left = (n - 2 - mid) / 2;
                Console.Write(new string('-',left));
                Console.Write('*');
                if(mid >= 0)
                {
                    Console.Write(new string('-', mid));
                    Console.Write('*');
                }
                Console.Write(new string('-',left));
                Console.WriteLine();
                mid = mid + 2;
            }
            mid = n - 4;
            for (int i = 1; i < (n + 1) / 2; i++)
            {
                
                var left = (n - 2 - mid) / 2;
                Console.Write(new string('-', left));
                Console.Write('*');
                if (mid >= 0)
                {
                    Console.Write(new string('-', mid));
                    Console.Write('*');
                }
                Console.Write(new string('-', left));
                Console.WriteLine();
                mid = mid - 2;
            }
        }
    }
}
