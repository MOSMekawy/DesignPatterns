namespace Prototype.Pattern
{
    public class Circle : Shape
    {
        public override int Width { get; }
        public override int Height { get; }
        public int Radius { 
            get
            {
                return Width;
            } 
        }
        public Circle(int radius)
        {
            Width = radius;
            Height = radius;
        }

        public override Shape Clone()
        {
            // one could also create a deep clone using json serlizer
            return (Shape)MemberwiseClone();
        }
    }
}
