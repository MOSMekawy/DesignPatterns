namespace AbstractFactory.Pattern
{
    public class FranceShippingCosts : IShippingCosts
    {
        public int CalculateShippingCosts()
        {
            return 125;
        }
    }
}
