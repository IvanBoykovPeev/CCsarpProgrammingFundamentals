using System;

namespace _07.ExchangeVariableValues
{
    class Program
    {
        static void Main()
        {
            var a = 5;
            var b = 10;
            var temporary = 0;
            Console.WriteLine("Before:");
            Console.WriteLine("a = {0}", a);
            Console.WriteLine("b = {0}", b);
            temporary = a;
            a = b;
            b = temporary;
            Console.WriteLine("After:");
            Console.WriteLine("a = {0}", a);
            Console.WriteLine("b = {0}", b);
        }
    }
}
