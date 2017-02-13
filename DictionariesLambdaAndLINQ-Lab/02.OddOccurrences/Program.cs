using System;
using System.Collections.Generic;

namespace _02.OddOccurrences
{
    class Program
    {
        static void Main()
        {
            Dictionary<string, int> counts = new Dictionary<string, int>();
            string input = Console.ReadLine().ToLower();
            string[] words = input.Split();
            foreach (var word in words)
            {
                if (counts.ContainsKey(word))
                {
                    counts[word]++;                    
                }
                else
                {
                    counts[word] = 1;
                }
            }
            List<string> results = new List<string>();
            foreach (var item in counts)
            {
                if (item.Value % 2 == 1)
                {
                    results.Add(item.Key);
                }
            }
            Console.WriteLine(string.Join(", ", results));
        }
    }
}
