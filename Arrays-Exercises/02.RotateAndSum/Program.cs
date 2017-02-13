using System;
using System.Linq;

namespace _02.RotateAndSum
{
    class Program
    {
        static void Main()
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int k = int.Parse(Console.ReadLine());
            int[] sum = new int[array.Length];
            for (int i = 0; i < k; i++)
            {
                
                int[] revers = new int[array.Length];
                int temp = array[array.Length - 1];
                revers[0] = temp;

                for (int j = 1; j < revers.Length; j++)
                {
                    revers[j] = array[j - 1];
                }

                for (int l = 0; l < array.Length; l++)
                {
                    sum[l] += revers[l];
                }
                array = revers;
            }
            Console.WriteLine(string.Join(" ", sum));
        }
    }
}
