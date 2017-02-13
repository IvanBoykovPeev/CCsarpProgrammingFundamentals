using System;
using System.Linq;

namespace _06.MaxSequenceOfEqualElements
{
    class Program
    {
        static void Main()
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int start = arr[0];
            int len = 1;

            int bestStart = 0;
            int bestLen = 1;

            for (int i = 1; i < arr.Length; i++)
            {
                for (int j = i; j < arr.Length; j++)
                {
                    if (start == arr[j])
                    {
                        len++;
                    }
                    else
                    {                        
                        break;
                    }
                }               

                if (len > bestLen)
                {
                    bestStart = arr[i];
                    bestLen = len;
                }

                start = arr[i];
                len = 1;
            }

            for (int i = 0; i < bestLen; i++)
            {
                Console.Write(bestStart + " ");
            }
            Console.WriteLine();
        }
    }
}
