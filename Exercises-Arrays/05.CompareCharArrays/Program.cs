using System;
using System.Linq;

namespace _05.CompareCharArrays
{
    class Program
    {
        static void Main()
        {
            char[] arr1 = Console.ReadLine().Split().Select(char.Parse).ToArray();
            char[] arr2 = Console.ReadLine().Split().Select(char.Parse).ToArray();
            int len = Math.Min(arr1.Length, arr2.Length);
            for (int i = 0; i < len; i++)
            {
                if (arr1[i] == arr2[i])
                {
                    if (arr1.Length < arr2.Length)
                    {
                        Console.WriteLine(arr1);
                        Console.WriteLine(arr2);
                        break;
                    }
                    else
                    {
                        Console.WriteLine(arr2);
                        Console.WriteLine(arr1);
                        break;
                    }
                }
                else if (arr1[i] < arr2[i])
                {
                    Console.WriteLine(arr1);
                    Console.WriteLine(arr2);
                    break;
                }
                else
                {
                    Console.WriteLine(arr2);
                    Console.WriteLine(arr1);
                    break;
                }
            }
        }
    }
}
