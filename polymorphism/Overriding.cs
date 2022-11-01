using System;

namespace polymorphism
{
    public class Shape
    {
        public virtual string PrintInfo()
        {
            return "print infor from shape";
        }
    }

    public class RectangleOverinding : Shape
    {
        public override string PrintInfo()
        {
            return base.PrintInfo() +  "print infor from rectangle";
        }
    }
}