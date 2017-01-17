using System;

namespace _04.DrawAFilledSquare
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            PrintTopAndBottom(n);
            for (int i = 0; i < n - 2; i++)
            {
            PrintMiddle(n);
            }
            PrintTopAndBottom(n);
        }

        private static void PrintMiddle(int n)
        {
            Console.Write("-");
            for (int i = 1; i < n; i++)
            {
                Console.Write("\\/");
            }
            Console.WriteLine("-");
        }

        private static void PrintTopAndBottom(int n)
        {
            Console.WriteLine(new string('-', 2 * n));
        }
    }
}
