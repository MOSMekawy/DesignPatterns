namespace Memento.Pattern
{
    public class CommandManager
    {
        private readonly Stack<AddCommandMemento> _mementos = new();
        private AddCommand? _command;
        public void Invoke(ICommand command)
        {
            if (_command == null)
            {
                _command = (AddCommand)command;
            }

            if (command.CanExecute())
            {
                command.Execute();
                _mementos.Push(((AddCommand)command).CreateMemento());
            }
        }

        public void Undo()
        {
            if (_mementos.Any())
            {
                _command?.Restore(_mementos.Pop());
                _command?.Undo();
            }
        }
    }
}
