using BridgePattern.Pattern;

var noDiscount = new NoDiscount();
var tenPercentDiscount = new TenPercentDiscount();

var monthlySubscriptionNoDiscount = new MonthlySubscription(noDiscount);
var monthlySubscription10PercentDiscount = new MonthlySubscription(tenPercentDiscount);

var yearlySubscriptionNoDiscount = new YearlySubscription(noDiscount);
var yearlySubscription10percentDiscount = new YearlySubscription(tenPercentDiscount);

Console.WriteLine($"Monthly subscription with no discount ---> {monthlySubscriptionNoDiscount.Price()}");
Console.WriteLine($"Monthly subscription with 10% discount ---> {monthlySubscription10PercentDiscount.Price()}");

Console.WriteLine($"Yearly subscription with no discount ---> {yearlySubscriptionNoDiscount.Price()}");
Console.WriteLine($"Yearly subscription with 10% discount ---> {yearlySubscription10percentDiscount.Price()}");