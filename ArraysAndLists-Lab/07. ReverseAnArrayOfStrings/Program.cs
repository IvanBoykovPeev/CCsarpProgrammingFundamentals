using System;

namespace _07.ReverseAnArrayOfStrings
{
    class Program
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split(' ');
            for (int i = 0; i < input.Length / 2; i++)
            {
                string current = input[i];
                input[i] = input[(input.Length - i) - 1];
                input[(input.Length - i) - 1] = current;
            }

            Console.WriteLine(string.Join(" ", input));
        }
    }
}
