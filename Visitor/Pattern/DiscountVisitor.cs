namespace Visitor.Pattern
{
    public class DiscountVisitor : IVisitor
    {
        public decimal TotalDiscountGiven { get; set; }
        public void VisitCustomer(Customer customer)
        {
            var discount = customer.AmountOrdered / 10;
            customer.Discount = discount;

            TotalDiscountGiven += discount;
        }

        public void VisitEmployee(Employee employee)
        {
            var discount = employee.YearsEmployed < 10 ? 100 : 200;
            employee.Discount = discount;
            TotalDiscountGiven += discount;
        }
    }
}
