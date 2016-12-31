using System;

namespace _09.ReversedChars
{
    class Program
    {
        static void Main()
        {
            char first = char.Parse(Console.ReadLine());
            char second = char.Parse(Console.ReadLine());
            char third = char.Parse(Console.ReadLine());
            Console.Write("{0}{1}{2}\n", third, second, first);
        }
    }
}
