using Visitor.Pattern;

var container = new Container();
container.Employees.Add(new Employee("Mekawy", 120, 2));
container.Employees.Add(new Employee("Samy", 100, 2));
container.Customers.Add(new Customer("Nourhan", 1200));

var discountVisitor = new DiscountVisitor();

container.Accept(discountVisitor);

foreach(var employee in container.Employees)
{
    Console.WriteLine($"Employee {employee.Name} got a {employee.Discount} discount.");
}

foreach (var customer in container.Customers)
{
    Console.WriteLine($"Customer {customer.Name} got a {customer.Discount} discount.");
}

Console.WriteLine($"Total discount given is {discountVisitor.TotalDiscountGiven}");