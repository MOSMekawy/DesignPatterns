namespace FactoryMethod.Pattern
{
    public class StaticDiscount : IDiscount
    {
        public double GetDiscount() => 0.1;
        
    }
}
