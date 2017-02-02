using System;

namespace _01.HelloName
{
    class Program
    {
        static void Main()
        {
            string name = Console.ReadLine();
            PrintGriiting(name);
        }

        private static void PrintGriiting(string name)
        {
            Console.WriteLine("Hello, {0}!", name);
        }
    }
}
