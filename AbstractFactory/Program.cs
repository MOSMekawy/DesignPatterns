using AbstractFactory.Pattern;

// a factory can be injected into a shopping cart service calculating cost of order and using the factory to get proper discount and shipping costs
var franceFactory = new FranceShoppingCartPurchaseFactory();
var franceDiscount = franceFactory.CreateDiscount();
var franceShippingCosts = franceFactory.CreateShippingCosts();

var egyptFactory = new EgyptShoppingCartPurchaseFactory();  
var egyptDiscount = egyptFactory.CreateDiscount();
var egyptShippingCosts = egyptFactory.CreateShippingCosts();
