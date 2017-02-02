using System;

namespace _05.FibonacciNumbers
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int fibNumber = FibNumber(n);
            Console.WriteLine(fibNumber);
        }

        private static int FibNumber(int n)
        {
            int fibNum0 = 1;
            int fibNum1 = 1;
            int result = 0;
            if (n == 0)
            {
                return fibNum0;
            }
            else if (n == 1)
            {
                return fibNum1;
            }
            else
            {
                for (int i = 2; i <= n; i++)
                {
                    result = fibNum0 + fibNum1;
                    fibNum0 = fibNum1;
                    fibNum1 = result;
                }
            }

            return result;
        }
    }
}
