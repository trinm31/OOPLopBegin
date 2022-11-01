using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            var rectangle = new Rectangle(3,4, 5);
            rectangle.GetArea();
            rectangle.GetVolume();
            rectangle.PrintInfo();
        }
    }
}