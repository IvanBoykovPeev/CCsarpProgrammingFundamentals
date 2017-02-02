using System;

namespace _06.PrimeChecker
{
    class Program
    {
        static void Main()
        {
            long number = long.Parse(Console.ReadLine());
            
            Console.WriteLine(IsPrime(number));
        }

        private static bool IsPrime(long number)
        {
            bool prime = true;
            if (number < 2)
            {
                prime = false;
                return prime;
            }
            else
            {
                int divider = 2;
                long maxDivider = (int)Math.Sqrt(number);
                while (prime && (divider <= maxDivider))
                {
                    if (number % divider == 0)
                    {
                        prime = false;
                    }
                    divider++;
                }
                return prime;
            }            
        }
    }
}
