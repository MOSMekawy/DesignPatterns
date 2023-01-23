namespace BridgePattern.Pattern
{
    public class YearlySubscription : Subscription
    {
        private readonly Discount _discount;
        public YearlySubscription(Discount discount)
        {
            _discount= discount;
        }
        public override int Price()
        {
            return (int)((1.0 - _discount.Value) * 100);
        }
    }
}
