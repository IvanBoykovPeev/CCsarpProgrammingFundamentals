using System;
using System.Linq;

namespace _05.ClosestTwoPoints
{
    class Program
    {
        static void Main()
        {
            Point[] points = Point.ReadPoints();
            Point[] closestPoints = Point.FindClosestTwoPoints(points);

            Point.PrintDistance(closestPoints);

            Point.PrintPoint(closestPoints[0]);
            Point.PrintPoint(closestPoints[1]);
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

        public static Point ReadPoint()
        {
            int[] pointInfo = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Point point = new Point(pointInfo[0], pointInfo[1]);
            return point;
        }

        public static Point[] ReadPoints()
        {
            int n = int.Parse(Console.ReadLine());
            Point[] points = new Point[n];
            for (int i = 0; i < n; i++)
            {
                points[i] = ReadPoint();
            }
            return points;
        }

        public static void PrintPoint(Point point)
        {
            Console.WriteLine("({0}, {1})", point.x, point.y);
        }

        public static void PrintDistance(Point[] point)
        {
            double distance = CalcDistance(point[0], point[1]);
            Console.WriteLine("{0:f3}", distance);
        }

        public static Point[] FindClosestTwoPoints(Point[] points)
        {
            double minDistance = double.MaxValue;
            Point[] closestTwoPoints = null;
            for (int p1 = 0; p1 < points.Length; p1++)
            {
                for (int p2 = p1 + 1; p2 < points.Length; p2++)
                {
                    double distance = CalcDistance(points[p1], points[p2]);
                    if (distance < minDistance)
                    {
                        minDistance = distance;
                        closestTwoPoints = new Point[] { points[p1], points[p2] };

                    }
                }
            }
            return closestTwoPoints;
        }
    }
}
