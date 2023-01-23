namespace Memento.Pattern
{
    public class AddCommandMemento
    {
        public CalculationResult Result { get; }
        public int Operand { get; }

        public AddCommandMemento(CalculationResult result, int operand)
        {
            Result = result;
            Operand = operand;
        }
    }
}
