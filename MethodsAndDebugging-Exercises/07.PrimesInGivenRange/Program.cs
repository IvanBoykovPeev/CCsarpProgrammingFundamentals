using System;
using System.Collections.Generic;

namespace _07.PrimesInGivenRange
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            Console.WriteLine(string.Join(", ", FindPrimesInRange(start, end)));
        }

        static List<int> FindPrimesInRange(int startNum, int endNum)
        {
            List<int> primeNumbers = new List<int>();
            for (int i = startNum; i <= endNum; i++)
            {
                if (CheckPrime(i))
                {
                    primeNumbers.Add(i);
                }                
            }
            return primeNumbers;
        }

        private static bool CheckPrime(int num)
        {
            bool isPrime = true;
            if (num < 2)
            {
                isPrime = false;
            }
            else
            {
                for (int i = 2; i <= Math.Sqrt(num); i++)
                {
                    if (num % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
            }
            return isPrime;
        }
    }
}
