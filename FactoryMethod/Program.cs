using FactoryMethod.Pattern;

var factories = new List<IDiscountFactory> { 
    new StaticDiscountFactory(), 
    new RandomDiscountFactory() 
};

foreach(var factory in factories)
{
    var discount = factory.CreateDiscount();
    Console.WriteLine($"{discount.GetType()} resulted in {discount.GetDiscount()} discount.");
}