namespace Facade.Pattern
{
    public class DiscountFacade
    {
        private readonly OrderService _orderService = new();
        private readonly CustomerDiscountBaseService _discountService = new();
        private readonly DayOfTheWeekFactorService _dayOfTheWeekFactorService = new();

        public double CalculateDiscountPercentage(int customerId)
        {
            if (!_orderService.HasEnoughOrders(customerId))
            {
                return 0;
            }

            return _discountService.CalculateDiscountBase(customerId) * _dayOfTheWeekFactorService.CalculateDayOfTheWeekFactor();
        }
    }
}
