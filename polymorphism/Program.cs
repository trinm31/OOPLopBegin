using System;

namespace polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            var rectangle = new Rectangle(3, 4);
            rectangle.Resize(6);
            rectangle.Resize(6,7);

            var rectangleOverinding = new RectangleOverinding();
            Console.WriteLine(rectangleOverinding.PrintInfo());
        }
    }
}