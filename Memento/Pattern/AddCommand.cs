namespace Memento.Pattern
{
    public class AddCommand : ICommand
    {
        private CalculationResult _calculation;
        private int _operand;
        public AddCommand(CalculationResult calculation, int operand)
        {
            _calculation = calculation;
            _operand = operand;
        }
        public bool CanExecute()
        {
            return true;
        }
        public AddCommandMemento CreateMemento()
        {
            return new AddCommandMemento(_calculation, _operand);
        }
        public void Restore(AddCommandMemento memento)
        {
            _calculation = memento.Result;
            _operand = memento.Operand;
        }
        public void Execute()
        {
            _calculation.Value += _operand;
        }

        public void Undo()
        {
            _calculation.Value -= _operand;
        }
    }
}
