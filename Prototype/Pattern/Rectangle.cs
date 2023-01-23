namespace Prototype.Pattern
{
    public class Rectangle : Shape
    {
        public override int Width { get; set; }
        public override int Height { get; set; }
        public Rectangle(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public override Shape Clone()
        {
            return (Shape)MemberwiseClone();
        }
    }
}
