namespace ChainOfResponsibility.Pattern
{
    public interface IHandler<T> where T : class
    {
        public void Handle(T request);
        public IHandler<T> SetNext(IHandler<T> next);
    }
}
