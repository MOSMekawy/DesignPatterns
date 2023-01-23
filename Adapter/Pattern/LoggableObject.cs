namespace ChainOfResponsibility.Pattern
{
    public class LoggableObject : ILoggableObject
    {
        public string GetLogInfo()
        {
            return "I am a loggable object";
        }
    }
}
