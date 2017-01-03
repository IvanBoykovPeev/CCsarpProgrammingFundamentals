using System;
using System.Linq;

namespace _08.SumArrays
{
    class Program
    {
        static void Main()
        {
            int[] arr1 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] arr2 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int len = Math.Max(arr1.Length, arr2.Length);
            var sumArr = new int[len];
            for (int position = 0; position < len; position++)
            {
                sumArr[position] = arr1[position % arr1.Length] + arr2[position % arr2.Length];
            }
            Console.WriteLine(string.Join(" ", sumArr));
        }
    }
}
