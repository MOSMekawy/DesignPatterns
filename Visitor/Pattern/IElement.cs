namespace Visitor.Pattern
{
    public interface IElement
    {
        void Accept(IVisitor visitor);
    }
}
