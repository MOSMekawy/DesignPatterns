namespace Command.Pattern
{
    public class DivideCommand : ICommand
    {
        private readonly CalculationResult _calculation;
        private readonly int _operand;
        public DivideCommand(CalculationResult calculation, int operand)
        {
            _calculation = calculation;
            _operand = operand;
        }

        public bool CanExecute()
        {
            return _operand != 0;
        }

        public void Execute()
        {
            _calculation.Value /= _operand;
        }

        public void Undo()
        {
            _calculation.Value *= _operand;
        }
    }
}
