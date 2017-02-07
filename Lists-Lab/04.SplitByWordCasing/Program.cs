using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.SplitByWordCasing
{
    class Program
    {
        static void Main()
        {
            var separator = new char[] { ',', ';', ':', '.', '!', '(', ')', '\"', '\'', '\\', '/', '[', ']', ' ' };
            var words = Console.ReadLine().Split(separator, StringSplitOptions.RemoveEmptyEntries).ToList();
            var lowerCaseWords = new List<string>();
            var mixedCaseWords = new List<string>();
            var upperCaseWords = new List<string>();
            foreach (var word in words)
            {
                var lowerCaseChar = 0;
                var upperCaseChar = 0;
                foreach (var letter in word)
                {
                    if (char.IsLower(letter))
                    {
                        lowerCaseChar++;
                    }
                    else if (char.IsUpper(letter))
                    {
                        upperCaseChar++;
                    }                    
                }
                if (lowerCaseChar == word.Length)
                {
                    lowerCaseWords.Add(word);
                }
                else if (upperCaseChar == word.Length)
                {
                    upperCaseWords.Add(word);
                }
                else
                {
                    mixedCaseWords.Add(word);
                }
            }
            Console.WriteLine("Lower-case: {0}", string.Join(", ", lowerCaseWords));
            Console.WriteLine("Mixed-case: {0}", string.Join(", ", mixedCaseWords));
            Console.WriteLine("Upper-case: {0}", string.Join(", ", upperCaseWords));
        }
    }
}
