namespace State.Pattern
{
    public class RegularState : BankAccountState
    {
        public RegularState(decimal balance, BankAccount bankAccount)
        {
            Balance = balance;
            BankAccount = bankAccount;
        }
        public override void Deposit(decimal amount)
        {
            Balance += amount;
            Console.WriteLine($"Deposited {amount}$");
        }

        public override void Withdraw(decimal amount)
        {
            Balance -= amount;
            Console.WriteLine($"Withdrew {amount}$");

            if (Balance < 0)
            {
                BankAccount.AccountState = new OverdrawnState(Balance, BankAccount);
            }
        }
    }
}
