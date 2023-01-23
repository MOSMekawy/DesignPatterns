namespace ChainOfResponsibility.Pattern
{
    public class ValidationFailedException : Exception
    {
        public ValidationFailedException(string message) : base(message) { }
    }
}
