using System;

namespace _5.SpecialNumbers
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                bool special = false;
                int sum = 0;
                int num = i;
                do
                {
                    sum += num % 10;
                    num /= 10;
                } while (num > 0);
                if (sum == 5 || sum == 7 || sum == 11)
                {
                    special = true;
                }
                Console.WriteLine("{0} -> {1}", i, special);
            }
        }
    }
}
