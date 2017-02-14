using System;
using System.Linq;

namespace _11.EqualSums
{
    class Program
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            bool hasSum = false;
            for (int i = 0; i < numbers.Length; i++)
            {
                int leftSum = 0;
                int rightSum = 0;
                              
                for (int j = 0; j < i; j++)
                {
                    leftSum += numbers[j];
                }

                for (int k = i + 1; k < numbers.Length; k++)
                {
                    rightSum += numbers[k];
                }

                if (leftSum == rightSum)
                {
                    Console.Write(i);
                    hasSum = true;
                    break;
                }
            }

            if (!hasSum)
            {
                Console.WriteLine("no");
            }
        }
    }
}
