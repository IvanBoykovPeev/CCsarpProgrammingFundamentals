using System;
using System.Linq;

namespace _05.TripleSum
{
    class Program
    {
        static void Main()
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            bool hasContains = false;
            for (int i = 0; i < input.Length; i++)
            {
                for (int j = i + 1; j < input.Length; j++)
                {
                    int a = input[i];
                    int b = input[j];
                    int sum = a + b;
                    if (input.Contains(sum))
                    {
                        Console.WriteLine($"{a} + {b} == {sum}");
                        hasContains = true;
                    }                    
                }
            }

            if (!hasContains)
            {
                Console.WriteLine("No");
            }            
        }
    }
}
