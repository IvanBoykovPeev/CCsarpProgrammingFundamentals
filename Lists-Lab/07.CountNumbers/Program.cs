using System;
using System.Linq;

namespace _07.CountNumbers
{
    class Program
    {
        static void Main()
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            var counts = new int[numbers.Max() + 1];
            foreach (var num in numbers)
            {
                counts[num]++;
            }
            for (int i = 0; i < counts.Length; i++)
            {
                if (counts[i] > 0)
                {
                    Console.WriteLine($"{i} -> {counts[i]}");
                }
            }
        }
    }
}
