// converting arabic numerals to roman numerals 
using Interpreter.Pattern;

var expressions = new List<RomanExpression>
{
    new RomanHunderedExpression(),
    new RomanTenExpression(),
    new RomanOneExpression()
};

var context = new RomanContext(5);

foreach(var expression in expressions)
{
    expression.Interpret(context);  
}

Console.WriteLine($"Translated arabic numerals to roman numerals 5 was translated to {context.Output}");

context = new RomanContext(881);

foreach (var expression in expressions)
{
    expression.Interpret(context);
}

Console.WriteLine($"Translated arabic numerals to roman numerals 851 was translated to {context.Output}");