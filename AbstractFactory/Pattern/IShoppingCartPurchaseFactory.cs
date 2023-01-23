namespace AbstractFactory.Pattern
{
    public interface IShoppingCartPurchaseFactory
    {
        public IDiscount CreateDiscount();
        public IShippingCosts CreateShippingCosts();
    }
}
