namespace LazyLoad.Pattern
{
    public class Order
    {
        public virtual Customer Customer { get; set; }

        public void PrintLabel()
        {
            Console.WriteLine($"Customer name is {Customer.Name}.");
        }
    }
}
