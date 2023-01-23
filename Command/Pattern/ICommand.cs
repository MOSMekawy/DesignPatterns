namespace Command.Pattern
{
    public interface ICommand
    {
        public bool CanExecute();
        public void Execute();
        public void Undo();
    }
}
