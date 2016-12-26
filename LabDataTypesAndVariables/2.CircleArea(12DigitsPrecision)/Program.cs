using System;

namespace _2.CircleArea_12DigitsPrecision_
{
    class Program
    {
        static void Main()
        {
            double r = double.Parse(Console.ReadLine());
            Console.WriteLine("{0:f12}", Math.PI * r * r);
        }
    }
}
