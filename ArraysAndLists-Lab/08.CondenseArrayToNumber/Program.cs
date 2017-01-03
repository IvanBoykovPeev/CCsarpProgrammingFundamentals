using System;
using System.Linq;

namespace _08.CondenseArrayToNumber
{
    class Program
    {
        static void Main()
        {
            int[] arr1 = Console.ReadLine().Split().Select(int.Parse).ToArray();

            while (arr1.Length > 1)
            {
                int[] condensed = new int[arr1.Length - 1];
                for (int i = 0; i < condensed.Length; i++)
                {
                    condensed[i] = arr1[i] + arr1[i + 1];
                }
                arr1 = condensed;
            }
            Console.WriteLine(arr1[0]);
        }
    }
}
