using Strategy.Pattern;

var consoleLogger = new ConsoleLogger();
var cloudLogger = new CloudLogger();    

var crucialService = new CrucialService();
crucialService.Logger = consoleLogger;
crucialService.DoCrucialStuff();

crucialService.Logger = cloudLogger;
crucialService.DoCrucialStuff();

crucialService.DoCrucialStuff(new ConsoleLogger());



