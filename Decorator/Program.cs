using Decorator.Pattern;
// Decorator & Proxy pattern are basically the same

var mailService = new MailService();
mailService.Send("mostafa.mekawy@enterprise.com", "Hey there !");


var consoleLogger = new ConsoleLogger();
var decoratedMailService = new MailServiceLoggerDecorator(mailService, consoleLogger);
decoratedMailService.Send("mostafa.mekawy@enterprise.com", "Hey there from decorated service !");