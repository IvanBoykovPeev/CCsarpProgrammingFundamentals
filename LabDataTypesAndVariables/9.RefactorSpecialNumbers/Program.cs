using System;

namespace _9.RefactorSpecialNumbers
{
    class Program
    {
        static void Main()
        {
            int inputNumber = int.Parse(Console.ReadLine());
            for (int i = 1; i <= inputNumber; i++)
            {
                int number = i;
                int sum = 0;
                bool isSpecialNumber = false;
                while (number > 0)
                {                    
                    sum += number % 10;
                    number = number / 10;
                }
                isSpecialNumber = (sum == 5) || (sum == 7) || (sum == 11);
                Console.WriteLine($"{i} -> {isSpecialNumber}");
            }
        }
    }
}
