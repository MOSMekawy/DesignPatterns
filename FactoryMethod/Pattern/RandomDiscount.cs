namespace FactoryMethod.Pattern
{
    public class RandomDiscount : IDiscount
    {
        public double GetDiscount()
        {
            Random rnd = new Random();

            return rnd.NextDouble() / 2;
        }
    }
}
