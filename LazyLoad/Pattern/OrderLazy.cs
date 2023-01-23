namespace LazyLoad.Pattern
{
    public class OrderLazy
    {
        private Lazy<Customer> _customerInitializer;

        public OrderLazy() { 
            // thread safe initializer
            _customerInitializer = new Lazy<Customer>(() => new Customer());
        }
        public Customer Customer { get { return _customerInitializer.Value; } }

        public void PrintLabel()
        {
            Console.WriteLine($"Customer name is {Customer.Name}.");
        }
    }
}
