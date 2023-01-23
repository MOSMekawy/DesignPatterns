namespace AbstractFactory.Pattern
{
    public class FranceShoppingCartPurchaseFactory : IShoppingCartPurchaseFactory
    {
        public IDiscount CreateDiscount()
        {
            return new FranceDiscount();
        }

        public IShippingCosts CreateShippingCosts()
        {
            return new FranceShippingCosts();
        }
    }
}
