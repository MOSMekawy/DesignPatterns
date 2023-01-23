namespace AbstractFactory.Pattern
{
    public class EgyptShippingCosts : IShippingCosts
    {
        public int CalculateShippingCosts()
        {
            return 50;
        }
    }
}
