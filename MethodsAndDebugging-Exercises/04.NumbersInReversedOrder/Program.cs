using System;

namespace _04.NumbersInReversedOrder
{
    class Program
    {
        static void Main()
        {
            string number = Console.ReadLine();
            Console.WriteLine(ReversNumber(number));
        }

        private static string ReversNumber(string number)
        {
            char[] resultToChar = number.ToCharArray();
            Array.Reverse(resultToChar);
            string result = string.Join("", resultToChar);
            return result;
        }
    }
}
