using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.CountRealNumbers
{
    class Program
    {
        static void Main()
        {
            SortedDictionary<double, int> counts = new SortedDictionary<double, int>();
            double[] input = Console.ReadLine().Split().Select(double.Parse).ToArray();
            foreach (var item in input)
            {
                if (!counts.ContainsKey(item))
                {
                    counts[item] = 1;
                }
                else
                {
                    counts[item]++;
                }
            }
            foreach (var item in counts)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
