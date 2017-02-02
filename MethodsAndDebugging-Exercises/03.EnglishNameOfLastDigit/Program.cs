using System;

namespace _03.EnglishNameOfLastDigit
{
    class Program
    {
        static void Main()
        {
            long number = long.Parse(Console.ReadLine());
            Console.WriteLine(LastDigitName(Math.Abs(number)));
        }

        private static string LastDigitName(long number)
        {
            long lastDigit = number % 10;
            string digitWord = "";
            switch (lastDigit)
            {
                case 0: digitWord = "zero"; break;
                case 1: digitWord = "one"; break;
                case 2: digitWord = "two"; break;
                case 3: digitWord = "three"; break;
                case 4: digitWord = "four"; break;
                case 5: digitWord = "five"; break;
                case 6: digitWord = "six"; break;
                case 7: digitWord = "seven"; break;
                case 8: digitWord = "eight"; break;
                case 9: digitWord = "nine"; break;
                default:
                    break;
            }
            return digitWord;
        }
    }
}
