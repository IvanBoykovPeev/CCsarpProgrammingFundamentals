using System;

namespace _08.CenterPoint
{
    class Program
    {
        static void Main()
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            GetMaxPoint(x1, y1, x2, y2);
        }

        private static void GetMaxPoint(double x1, double y1, double x2, double y2)
        {
            double r1 = Math.Sqrt(Math.Pow(x1, 2) + Math.Pow(y1, 2));
            double r2 = Math.Sqrt(Math.Pow(x2, 2) + Math.Pow(y2, 2));
            if (r1 <= r2)
            {
                Console.WriteLine("({0}, {1})", x1, y1);
            }
            else
            {
                Console.WriteLine("({0}, {1})", x2, y2);
            }
        }
    }
}
