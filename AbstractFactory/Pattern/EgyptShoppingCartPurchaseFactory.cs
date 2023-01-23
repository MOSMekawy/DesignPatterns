namespace AbstractFactory.Pattern
{
    public class EgyptShoppingCartPurchaseFactory : IShoppingCartPurchaseFactory
    {
        public IDiscount CreateDiscount()
        {
            return new EgyptDiscount();
        }

        public IShippingCosts CreateShippingCosts()
        {
            return new EgyptShippingCosts();
        }
    }
}
