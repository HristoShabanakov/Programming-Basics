using System;

namespace _09.House
{
    class Program
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            var stars = 1;
            if(n % 2 == 0)
            {
                stars = 2;
            }
            for (int row = 0; row < (n+1) / 2; row++)
            {
                var hyphens = (n - stars) / 2;
                Console.Write(new string('-', hyphens));
                Console.Write(new string('*',stars));
                Console.Write(new string('-',hyphens));
                Console.WriteLine();
                stars = stars + 2;
            }
            var bodyRows = n / 2;

            for (int row = 0; row < bodyRows; row++)
            {
                Console.Write('|');
                Console.Write(new string('*',n-2));
                Console.WriteLine('|');
            }
        }
    }
}
