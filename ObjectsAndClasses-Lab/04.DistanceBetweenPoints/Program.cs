using System;
using System.Linq;

namespace _03.BigFactorial
{
    class Program
    {
        static void Main()
        {
            int[] pointInfo1 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] pointInfo2 = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Point point1 = new Point(pointInfo1[0], pointInfo1[1]);
            Point point2 = new Point(pointInfo2[0], pointInfo2[1]);

            double distance = Point.CalcDistance(point1, point2);

            Console.WriteLine("{0:f3}", distance);
        }
    }

    public class Point
    {
        private int x;
        private int y;

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public static double CalcDistance(Point p1, Point p2)
        {
            double distance = 0.0;
            double deltaX = Math.Abs(p2.x - p1.x);
            double deltaY = Math.Abs(p2.y - p1.y);
            distance = Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
            return distance;
        }
    }
}
