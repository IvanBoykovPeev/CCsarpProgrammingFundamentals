using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Largest3Numbers
{
    class Program
    {
        static void Main()
        {
            List<int> numbers = new List<int>();
            numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            int[] largestTree = numbers.OrderByDescending(x => x).Take(3).ToArray();

            Console.WriteLine(string.Join(" ", largestTree));
        }
    }
}
