using System;
using System.Collections.Generic;
using System.Linq;

namespace Lists_Exercises
{
    class Program
    {
        static void Main()
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            int start = numbers[0];
            int lenght = 1;

            int bestStart = 0;
            int bestLenght = 1;

            for (int i = 1; i < numbers.Count; i++)
            {
                for (int j = i; j < numbers.Count; j++)
                {
                    if (start == numbers[j])
                    {
                        lenght++;
                    }
                    else
                    {
                        break;
                    }
                }

                if (lenght > bestLenght)
                {
                    bestStart = i - 1;
                    bestLenght = lenght;
                }

                start = numbers[i];
                lenght = 1;
            }
            
            Console.WriteLine(string.Join(" ", numbers.GetRange(bestStart, bestLenght)));
        }
    }
}
