using System;

namespace _16.ComparingFloats
{
    class Program
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double eps = 0.000001;
            bool res = Math.Max(a, b) - Math.Min(a, b) < eps;
            Console.WriteLine(res);
        }
    }
}
