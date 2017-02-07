using System;
using System.Linq;

namespace _007.CountNumbers
{
    class Program
    {
        static void Main()
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            numbers.Sort();
            var pos = 0;
            while (pos < numbers.Count)
            {
                int num = numbers[pos];
                int count = 1;
                while (pos + count < numbers.Count && numbers[pos + count] == num)
                {
                    count++;
                }
                pos = pos + count;
                Console.WriteLine($"{num} -> {count}");
            }
        }
    }
}
