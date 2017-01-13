using System;
using System.Collections.Generic;
using System.Linq;

namespace _12.SumAdjacentEqualNumbers
{
    class Program
    {
        static void Main()
        {
            List<decimal> numbers = new List<decimal>();
            numbers = Console.ReadLine().Split().Select(decimal.Parse).ToList();
            int pos = 0;
            while (pos < numbers.Count - 1)
            {
                if (numbers[pos] == numbers[pos + 1])
                {                    
                    numbers.RemoveAt(pos);
                    numbers[pos] = 2 * numbers[pos];
                    if (pos > 0)
                    {
                    pos--;
                    }
                }
                else
                {
                    pos++;
                }
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
