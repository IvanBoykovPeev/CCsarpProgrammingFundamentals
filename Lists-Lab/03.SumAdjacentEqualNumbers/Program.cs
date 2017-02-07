using System;
using System.Linq;

namespace _03.SumAdjacentEqualNumbers
{
    class Program
    {
        static void Main()
        {
            var nums = Console.ReadLine().Split().Select(double.Parse).ToList();
            int pos = 0;
            while (pos < nums.Count - 1)
            {
                if (nums[pos] == nums[pos + 1])
                {
                    nums.RemoveAt(pos);
                    nums[pos] = 2 * nums[pos];
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
            Console.WriteLine(string.Join(" ", nums));
        }
    }
}
