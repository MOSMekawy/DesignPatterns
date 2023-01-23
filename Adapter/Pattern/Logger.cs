namespace ChainOfResponsibility.Pattern
{
    public class Logger
    {
        public void LogToConsole(ILoggableObject obj)
        {
            Console.WriteLine(obj.GetLogInfo());
        }
    }
}
