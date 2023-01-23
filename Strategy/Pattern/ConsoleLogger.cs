namespace Strategy.Pattern
{
    public class ConsoleLogger : ILogger
    {
        public void LogMessage(string messsage)
        {
            Console.WriteLine("Console logger is displaying message");
            Console.WriteLine(messsage);
        }
    }
}
