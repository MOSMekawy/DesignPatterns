namespace Strategy.Pattern
{
    internal class CloudLogger : ILogger
    {
        public void LogMessage(string messsage)
        {
            Console.WriteLine("Cloud logger is logging message.");
            Console.WriteLine(messsage);
        }
    }
}
