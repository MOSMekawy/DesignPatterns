namespace BridgePattern.Pattern
{
    public class MonthlySubscription : Subscription
    {
        private readonly Discount _discount;
        public MonthlySubscription(Discount discount)
        {
            _discount = discount;
        }
        public override int Price()
        {
            return (int)((1.0 - _discount.Value) * 10);
        }
    }
}
