namespace Facade.Pattern
{
    public class OrderService
    {
        public bool HasEnoughOrders(int customerId) => customerId > 5;
    }
}
