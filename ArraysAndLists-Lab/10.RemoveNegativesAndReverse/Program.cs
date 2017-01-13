using System;
using System.Collections.Generic;
using System.Linq;

namespace _10.RemoveNegativesAndReverse
{
    class Program
    {
        static void Main()
        {
            List<int> nums = new List<int>();
            nums = Console.ReadLine().Split().Select(int.Parse).ToList();

            List<int> result = new List<int>();

            for (int i = 0; i < nums.Count; i++)
            {
                if (nums[i] > 0)
                {
                    result.Add(nums[i]);
                }
            }
            result.Reverse();
            if (result.Count > 0)
            {
            Console.WriteLine(string.Join(" ", result));
            }
            else
            {
                Console.WriteLine("empty");
            }
        }
    }
}
