using Command.Pattern;

var calcResult = new CalculationResult();
var commandManager = new CommandManager();

commandManager.Invoke(new AddCommand(calcResult, 2));
Console.WriteLine($"value should be 2 --- {calcResult.Value}");

commandManager.Invoke(new MultiplyCommand(calcResult, 3));
Console.WriteLine($"value should be 6 --- {calcResult.Value}");

commandManager.Invoke(new DivideCommand(calcResult, 0));
Console.WriteLine($"value should be 6 --- {calcResult.Value}");

commandManager.Invoke(new DivideCommand(calcResult, 2));
Console.WriteLine($"value should be 3 --- {calcResult.Value}");

commandManager.Undo();
Console.WriteLine($"value should be 6 --- {calcResult.Value}");