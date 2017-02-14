using System;
using System.Linq;

namespace _06.RectanglePosition
{
    public class Program
    {
        static void Main()
        {
            Rectangle r1 = Rectangle.ReadRectangle();
            Rectangle r2 = Rectangle.ReadRectangle();

            Console.WriteLine(r1.IsInside(r2) ? "Inside" : "Not inside");
        }
    }

    public class Rectangle
    {
        public int Top { get; set; }
        public int Left { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public int Bottom
        {
            get
            {
                return Top + Height;
            }
        }
        public int Right
        {
            get
            {
                return Left + Width;
            }
        }

        public static Rectangle ReadRectangle()
        {
            int[] rectangleInfo = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Rectangle rectangle = new Rectangle();
            rectangle.Left = rectangleInfo[0];
            rectangle.Top = rectangleInfo[1];
            rectangle.Width = rectangleInfo[2];
            rectangle.Height = rectangleInfo[3];
            return rectangle;
        }

        public bool IsInside(Rectangle r1)
        {
            return (r1.Left <= Left) && (r1.Right >= Right) && (r1.Top <= Top) && (r1.Bottom >= Bottom);
        }
    }    
}
