using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.EiffelTower
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0}**{0}", new string('-', n + 2));
                //Console.Write(new string('-', n + 2));
                //Console.Write(new string('*', 2));
                //Console.Write(new string('-', n + 2));
                //Console.WriteLine();
            }

            for (int i = 0; i < n - 3; i++)
            {
                Console.WriteLine("{0}****{0}", new string('-', n + 1));
                //Console.Write(new string('-', n + 1));
                //Console.Write(new string('*', 4));
                //Console.Write(new string('-', n + 1));
                //Console.WriteLine();
            }

            Console.WriteLine("{0}******{0}", new string('-', n));
            //Console.Write(new string('-',n));
            //Console.Write(new string('*',6));
            //Console.Write(new string('-', n));
            //Console.WriteLine();

            for (int i = 0; i < n - 4; i++)
            {
                Console.WriteLine("{0}**--**{0}", new string('-', n));
                //Console.Write(new string('-', n));
                //Console.Write(new string('*', 2));
                //Console.Write(new string('-', 2));
                //Console.Write(new string('*', 2));
                //Console.Write(new string('-', n));
                //Console.WriteLine();
            }

            for (int i = 0; i < n - 3; i++)
            {
                Console.WriteLine("{0}**----**{0}", new string('-', n - 1));
                // Console.Write(new string('-', n-1));
                // Console.Write(new string('*', 2));
                // Console.Write(new string('-', 4));
                // Console.Write(new string('*', 2));
                // Console.Write(new string('-', n - 1));
                // Console.WriteLine();
            }
            Console.WriteLine("{0}**********{0}", new string('-', n - 2));
            //Console.Write(new string('-', n - 2));
            //Console.Write(new string('*', 10));
            //Console.Write(new string('-', n - 2));
            //Console.WriteLine();

            for (int i = n - 3; i > 0; i--)
            {
                Console.WriteLine("{0}**{1}**{0}", new string('-', i), new string('-', 2 * n - 2 * i + 2));
                //Console.Write(new string('-', i));
                //Console.Write(new string('*', 2));
                //Console.Write(new string('-', 2 * n -2 * i + 2));
                //Console.Write(new string('*', 2));
                //Console.Write(new string('-', i));
                //Console.WriteLine();
            }
            Console.WriteLine("***{0}***", new string('-', 2 * n));
        }
    }
}
