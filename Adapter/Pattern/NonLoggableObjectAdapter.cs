namespace ChainOfResponsibility.Pattern
{
    public class NonLoggableObjectAdapter : ILoggableObject
    {
        private NonLoggableObject _adaptee { get; set; }
        public NonLoggableObjectAdapter(NonLoggableObject adaptee)
        {
            _adaptee = adaptee;
        }
        public string GetLogInfo()
        {
            return $"Object id {_adaptee.Id} and value {_adaptee.Value}";
        }
    }
}
