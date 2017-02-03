using System;

namespace _09.LongerLine
{
    class Program
    {
        static void Main()
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());
            double x4 = double.Parse(Console.ReadLine());
            double y4 = double.Parse(Console.ReadLine());

           GetMaxDistance(x1, y1, x2, y2, x3, y3, x4, y4);
        }

        private static void GetMaxDistance(double x1, double y1, double x2, double y2,
            double x3, double y3, double x4, double y4)
        {
            double distanceLine1 = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            double distanceLine2 = Math.Sqrt(Math.Pow(x4 - x3, 2) + Math.Pow(y4 - y3, 2));
            if (distanceLine1 >= distanceLine2)
            {
                if (GetMaxPoint(x1, y1, x2, y2))
                {
                    Console.WriteLine("({0}, {1})({2}, {3})", x1, y1, x2, y2);
                }
                else
                {
                    Console.WriteLine("({0}, {1})({2}, {3})", x2, y2, x1, y1);
                }                
            }
            else
            {
                if (GetMaxPoint(x3, y3, x4, y4))
                {
                    Console.WriteLine("({0}, {1})({2}, {3})", x3, y3, x4, y4);
                }
                else
                {
                    Console.WriteLine("({0}, {1})({2}, {3})", x4, y4, x3, y3);
                }                
            }
        }

        private static bool GetMaxPoint(double x1, double y1, double x2, double y2)
        {
            double r1 = Math.Sqrt(Math.Pow(x1, 2) + Math.Pow(y1, 2));
            double r2 = Math.Sqrt(Math.Pow(x2, 2) + Math.Pow(y2, 2));
            if (r1 <= r2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
