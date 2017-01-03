using System;

namespace _01.LargestCommonEnd
{
    class Program
    {
        static void Main()
        {
            string[] firstArray = Console.ReadLine().Split();
            string[] secondArray = Console.ReadLine().Split();

            int smallerArrayLenght = Math.Min(firstArray.Length, secondArray.Length);

            int leftCounter = NewMethod(firstArray, secondArray, smallerArrayLenght);

            Array.Reverse(firstArray);
            Array.Reverse(secondArray);

            int rightCounter = NewMethod(firstArray, secondArray, smallerArrayLenght);

            Console.WriteLine(Math.Max(leftCounter, rightCounter));
        }

        private static int NewMethod(string[] firstArray, string[] secondArray, int smallerArrayLenght)
        {
            int counter = 0;
            for (int i = 0; i < smallerArrayLenght; i++)
            {
                if (firstArray[i] == secondArray[i])
                {
                    counter++;
                }
                else
                {
                    break;
                }
            }

            return counter;
        }
    }
}
