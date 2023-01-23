using Memento.Pattern;

var calcResult = new CalculationResult();
var commandManager = new CommandManager();

commandManager.Invoke(new AddCommand(calcResult, 2));
Console.WriteLine($"value should be 2 --- {calcResult.Value}");

commandManager.Invoke(new AddCommand(calcResult, 12));
Console.WriteLine($"value should be 14 --- {calcResult.Value}");

commandManager.Invoke(new AddCommand(calcResult, 45));
Console.WriteLine($"value should be 59 --- {calcResult.Value}");

commandManager.Undo();
Console.WriteLine($"value should be 14 --- {calcResult.Value}");
