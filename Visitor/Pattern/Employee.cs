namespace Visitor.Pattern
{
    public class Employee : IElement
    {
        public int YearsEmployed { get; set; }
        public string Name { get; set; }
        public int AmountOrdered { get; set; }
        public decimal Discount { get; set; }
        public Employee(string name, int amountOrdered, int yearsEmployed)
        {
            Name = name;
            AmountOrdered = amountOrdered;
            YearsEmployed = yearsEmployed;
        }

        public void Accept(IVisitor visitor)
        {
            visitor.VisitEmployee(this);
        }
    }
}