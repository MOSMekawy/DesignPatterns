namespace Facade.Pattern
{
    public class CustomerDiscountBaseService
    {
        public double CalculateDiscountBase(int customerId) => customerId > 8 ? 10 : 20;
    }
}
