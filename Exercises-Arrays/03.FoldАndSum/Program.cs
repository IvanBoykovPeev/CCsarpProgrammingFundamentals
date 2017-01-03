using System;
using System.Linq;

namespace _03.FoldАndSum
{
    class Program
    {
        static void Main()
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int k = array.Length / 4;
            int[] firstElement = new int[k];
            int[] middleElement = new int[2 * k];
            int[] lastElement = new int[k];

            for (int i = 0; i < firstElement.Length; i++)
            {
                firstElement[i] = array[i];
            }

            for (int j = 0; j < lastElement.Length; j++)
            {
                lastElement[j] = array[3 * k + j];
            }

            for (int i = 0; i < middleElement.Length; i++)
            {
                middleElement[i] = array[k + i];
            }

            Array.Reverse(firstElement);
            Array.Reverse(lastElement);

            int[] firstLastElement = new int[2 * k];
            for (int l = 0; l < firstLastElement.Length; l++)
            {
                if (l < k)
                {
                    firstLastElement[l] = firstElement[l];
                }
                else
                {
                    firstLastElement[l] = lastElement[l - k];
                }
            }
            
            int[] sum = new int[2 * k];
            for (int i = 0; i < sum.Length; i++)
            {
                sum[i] = middleElement[i] + firstLastElement[i];
            }
            Console.WriteLine(string.Join(" ", sum));
        }
    }
}
