using System;
using System.Linq;

namespace _09.ExtractMiddleElements
{
    class Program
    {
        static void Main()
        {
            int[] arr1 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            if (arr1.Length == 1)
            {
                Console.WriteLine(arr1[0]);
            }
            else if (arr1.Length % 2 == 0)
            {
                Console.WriteLine("{ " + arr1[arr1.Length / 2 - 1] + ", " + arr1[arr1.Length / 2] + " }");
            }
            else
            {
                Console.WriteLine("{ " + arr1[arr1.Length / 2 - 1] + ", " + arr1[arr1.Length / 2] + ", " + arr1[arr1.Length / 2 + 1] + " }");
            }
        }
    }
}
