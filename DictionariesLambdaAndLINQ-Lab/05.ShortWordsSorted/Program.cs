using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.ShortWordsSorted
{
    class Program
    {
        static void Main()
        {
            List<string> text = new List<string>();
            text = Console.ReadLine().ToLower()
                .Split(new char[] { '.', ',', ':', ';', '(', ')', '[', ']', '"', '\'',
                '\\', '/', '!', '?', ' '} , StringSplitOptions.RemoveEmptyEntries)
                .Where(t => t.Length < 5)
                .OrderBy(t => t)
                .Distinct()
                .ToList();
            Console.WriteLine(string.Join(", ", text));
        }
    }
}
