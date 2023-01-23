using Template.Pattern;

var exchangeParser = new ExchangeMailParser();
Console.WriteLine(exchangeParser.ParseMailBody(Guid.NewGuid().ToString()));
Console.WriteLine();

var apacheParser = new ApacheMailParser();
Console.WriteLine(apacheParser.ParseMailBody(Guid.NewGuid().ToString()));
Console.WriteLine();