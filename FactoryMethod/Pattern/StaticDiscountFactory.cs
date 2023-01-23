namespace FactoryMethod.Pattern
{
    public class StaticDiscountFactory : IDiscountFactory
    {
        public IDiscount CreateDiscount()
        {
            return new StaticDiscount();
        }
    }
}
