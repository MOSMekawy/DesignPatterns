﻿namespace Command.Pattern
{
    public class AddCommand : ICommand
    {
        private readonly CalculationResult _calculation;
        private readonly int _operand;
        public AddCommand(CalculationResult calculation, int operand)
        {
            _calculation = calculation;
            _operand = operand;
        }
        public bool CanExecute()
        {
            return true;
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
