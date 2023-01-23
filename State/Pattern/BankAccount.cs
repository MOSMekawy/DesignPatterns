namespace State.Pattern
{
    public class BankAccount
    {
        public BankAccountState AccountState { get; set; }
        public decimal Balance { get { return AccountState.Balance; } }

        public BankAccount()
        {
            AccountState = new RegularState(200, this);
        }

        public void Deposit(decimal amount)
        {
            AccountState.Deposit(amount);
        }

        public void Withdraw(decimal amount)
        {
            AccountState.Withdraw(amount);
        }
    }
}