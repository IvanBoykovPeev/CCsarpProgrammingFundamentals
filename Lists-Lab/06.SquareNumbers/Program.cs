using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.SquareNumbers
{
    class Program
    {
        static void Main()
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> squares = new List<int>();
            foreach (var num in numbers)
            {
                if (Math.Sqrt(num) == (int)(Math.Sqrt(num)))
                {
                    squares.Add(num);
                }
            }
            squares.Sort((a, b) => b.CompareTo(a));
            Console.WriteLine(string.Join(" ", squares));
        }
    }
}
