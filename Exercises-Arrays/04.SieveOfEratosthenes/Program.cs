using System;

namespace _04.SieveOfEratosthenes
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            bool[] primes = new bool[n + 1];
            primes[0] = primes[1] = false;
            for (int i = 2; i < primes.Length; i++)
            {
                    primes[i] = true;                
            }

            for (int i = 2; i < Math.Sqrt(n); i++)
            {
                if (primes[i])
                {
                    for (int j = i * i, k = 1; j < primes.Length; j = j + k * i)
                    {
                        primes[j] = false;
                    }
                }
            }

            for (int i = 2; i < primes.Length; i++)
            {
                if (primes[i])
                {
                    Console.Write("{0} ", i);
                }                
            }
            Console.WriteLine();
        }
    }
}
