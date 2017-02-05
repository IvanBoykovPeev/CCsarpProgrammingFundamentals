using System;

namespace _11.GeometryCalculator
{
    class Program
    {
        static void Main()
        {
            string figure = Console.ReadLine();
            switch (figure)
            {
                case "triangle":
                    CalculateleTriangleArea();
                    break;
                case "square":
                    CalculateSquareleArea();
                    break;
                case "rectangle":
                    CalculateRectangleleArea();
                    break;
                case "circle":
                    CalculateCircleleArea();
                    break;
                default:
                    break;
            }
        }

        private static void CalculateCircleleArea()
        {
            double radius = double.Parse(Console.ReadLine());
            double area = Math.PI *(radius * radius);
            Console.WriteLine("{0:f2}", area);
        }

        private static void CalculateRectangleleArea()
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double area = width * height;
            Console.WriteLine("{0:f2}", area);
        }

        private static void CalculateleTriangleArea()
        {
            double side = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double area = side * height / 2;
            Console.WriteLine("{0:f2}", area);
        }

        private static void CalculateSquareleArea()
        {
            double side = double.Parse(Console.ReadLine());
            double area = side * side;
            Console.WriteLine("{0:f2}", area);
        }
    }
}
