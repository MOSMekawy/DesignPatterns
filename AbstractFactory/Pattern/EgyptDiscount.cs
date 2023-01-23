namespace AbstractFactory.Pattern
{
    public class EgyptDiscount : IDiscount
    {
        public double GetDiscount()
        {
            return 0.15;
        }
    }
}
