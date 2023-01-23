namespace Visitor.Pattern
{
    public class Customer : IElement
    {
        public string Name { get; set; }    
        public int AmountOrdered { get; set; }
        public decimal Discount { get; set; }
        public Customer(string name, int amountOrdered)
        {
            Name = name;
            AmountOrdered = amountOrdered;
        }

        public void Accept(IVisitor visitor)
        {
            visitor.VisitCustomer(this);
        }
    }
}