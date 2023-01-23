using Observer.Pattern;

var resellerSVC = new TicketResellerService();
var stockSVC = new TicketStockService();

var notifier = new OrderService();
notifier.AddObserver(resellerSVC);
notifier.AddObserver(stockSVC);

notifier.CompleteTicketSale(2, 100);

