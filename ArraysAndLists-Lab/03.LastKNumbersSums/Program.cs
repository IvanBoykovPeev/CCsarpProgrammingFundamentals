using System;

namespace _03.LastKNumbersSums
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            long[] sequence = new long[n];
            sequence[0] = 1;

            for (int i = 1; i < n; i++)
            {
                var start = Math.Max(0, i - k);
                var end = i - 1;
                long sum = Sum(start, end, sequence);
                sequence[i] = sum;
            }
            foreach (var item in sequence)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        private static long Sum(int start, int end, long[] arr)
        {
            long sum = 0;
            for (int i = start; i <= end; i++)
            {
                sum = sum + arr[i];
            }
            return sum;
        }
    }
}
