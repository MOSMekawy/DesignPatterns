namespace Prototype.Pattern
{
    public abstract class Shape
    {
        public abstract int Width { get; }
        public abstract int Height { get; }
        public abstract Shape Clone();
    }
}
