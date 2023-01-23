namespace AbstractFactory.Pattern
{
    public class FranceDiscount : IDiscount
    {
        public double GetDiscount()
        {
            return 0.1;
        }
    }
}
