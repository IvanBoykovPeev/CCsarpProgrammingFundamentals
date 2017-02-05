using System;
using System.Collections.Generic;

namespace _12.MasterNumber
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                if (ContainsEvenDigit(i) && SumOfDigits(i) && IsPalindrome(i))
                {
                    Console.WriteLine(i);
                }
            }
        }

        static bool IsPalindrome(int num)
        {
            int ind = 1;
            List<int> numbers = new List<int>();
            while (num > 0)
            {
                numbers.Add(num % 10);
                num /= 10;
                ind++;
            }
            numbers.Reverse();
            for (int j = 0; j < numbers.Count / 2; j++)
            {
                if (numbers[j] != numbers[numbers.Count - j - 1])
                {                    
                    return false;
                }
            }
            return true;
        }

        static bool SumOfDigits(int num)
        {
            int sum = 0;
            while (num > 0)
            {
                sum += num % 10;
                num /= 10;
            }
            if (sum % 7 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static bool ContainsEvenDigit(int num)
        {
            int curNum = num;
            while (num > 0)
            {
                curNum = num % 10;
                if (curNum % 2 == 0)
                {
                    return true;
                }
                num /= 10;
            }
            return false;
        }
    }
}
