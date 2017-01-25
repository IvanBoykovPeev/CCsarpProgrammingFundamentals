using System;

namespace _06.MathPower
{
    class Program
    {
        static void Main()
        {
            double number = double.Parse(Console.ReadLine());
            double power = double.Parse(Console.ReadLine());
            double result = RaiseToPower(number, power);
            Console.WriteLine(result);
        }

        private static double RaiseToPower(double number, double power)
        {
            double result = number;

            for (int i = 1; i < power; i++ )
            {
                result = result * number;
            }

            return result;
        }
    }
}
