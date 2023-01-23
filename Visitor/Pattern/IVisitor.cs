namespace Visitor.Pattern
{
    public interface IVisitor
    {
        public void VisitCustomer(Customer customer);
        public void VisitEmployee(Employee employee);
    }
}