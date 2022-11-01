using System;

namespace Inheritance
{
    public class Shape
    {
        public Shape(int width, int height)
        {
            Width = width;
            Height = height;
        }
        public int Width { get; set; }
        public int Height { get; set; }

        public void PrintInfo()
        {
            Console.WriteLine($"width: {Width}/ height: {Height}");
        }
    }

    public class Rectangle : Shape
    {
        public int Deep { get; set; }
        public Rectangle(int width, int height, int deep) : base(width, height)
        {
            Deep = deep;
        }
        public int GetArea()
        {
            return Height * Width;
        }
        
        public int GetVolume()
        {
            return Height * Width * Deep;
        }
    }
}