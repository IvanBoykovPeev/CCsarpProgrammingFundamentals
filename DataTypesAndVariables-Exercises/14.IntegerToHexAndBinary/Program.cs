using System;

namespace _14.IntegerToHexAndBinary
{
    class Program
    {
        static void Main()
        {
            int decimalNumber = int.Parse(Console.ReadLine());
            string hexadecimal = Convert.ToString(decimalNumber, 16);
            string binari = Convert.ToString(decimalNumber, 2);
            Console.WriteLine(hexadecimal.ToUpper());
            Console.WriteLine(binari);
        }
    }
}
