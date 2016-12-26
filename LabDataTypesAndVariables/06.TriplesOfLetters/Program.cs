using System;

namespace _06.TriplesOfLetters
{
    class Program
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            
            for (int num1 = 0; num1 < num; num1++)
            {                
                for (int num2 = 0; num2 < num; num2++)
                {                   
                    for (int num3 = 0; num3 < num; num3++)
                    {
                        char letter1 = (char)('a' + num1);
                        char letter2 = (char)('a' + num2);
                        char letter3 = (char)('a' + num3);
                        Console.WriteLine("{0}{1}{2}", letter1, letter2, letter3);
                    }
                }                
            }
        }
    }
}
