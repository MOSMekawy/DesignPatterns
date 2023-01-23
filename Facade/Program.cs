using Facade.Pattern;

var facade = new DiscountFacade();

Console.WriteLine(facade.CalculateDiscountPercentage(2));

Console.WriteLine(facade.CalculateDiscountPercentage(8));