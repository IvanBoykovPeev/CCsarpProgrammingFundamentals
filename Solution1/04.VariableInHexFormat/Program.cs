using System;

namespace _04.VariableInHexFormat
{
    class Program
    {
        static void Main()
        {
            int number = Convert.ToInt32(Console.ReadLine(), 16);
            decimal decNum = Convert.ToDecimal(number);
            Console.WriteLine(decNum);
        }
    }
}
