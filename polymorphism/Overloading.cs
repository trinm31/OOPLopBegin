namespace polymorphism
{
    public class Rectangle
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public Rectangle(int width, int height)
        {
            Width = width;
            Height = height;
        }
        
        // overload method
        public void Resize(int sameSize)
        {
            Width = sameSize;
            Height = sameSize;
        }

        public void Resize(int width, int height)
        {
            Width = width;
            Height = height;
        }
    }
}