namespace FactoryMethod.Pattern
{
    public class RandomDiscountFactory : IDiscountFactory
    {
        public IDiscount CreateDiscount()
        {
            return new RandomDiscount();
        }
    }
}
