using System;

namespace _10.CubeProperties
{
    class Program
    {
        static void Main()
        {
            double side = double.Parse(Console.ReadLine());
            string action = Console.ReadLine();
            switch (action)
            {
                case "face": GetFace(side); break;
                case "space": GetSpace(side); break;
                case "volume": GetVolume(side); break;
                case "area": GetArea(side); break;
                default:
                    break;
            }            
        }

        private static void GetArea(double side)
        {
            double area = 6 * Math.Pow(side, 2);
            Console.WriteLine(Math.Round(area, 2));
        }

        private static void GetVolume(double side)
        {
            double volume = Math.Pow(side, 3);
            Console.WriteLine(Math.Round(volume, 2));
        }

        private static void GetSpace(double side)
        {
            double spaceDiagonals = Math.Sqrt(3 * Math.Pow(side, 2));
            Console.WriteLine(Math.Round(spaceDiagonals, 2));
        }

        private static void GetFace(double side)
        {
            double faceDiagonals = Math.Sqrt(2 * Math.Pow(side, 2));
            Console.WriteLine(Math.Round(faceDiagonals, 2));
        }
    }
}
