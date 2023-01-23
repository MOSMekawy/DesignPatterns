namespace State.Pattern
{
    public class OverdrawnState : BankAccountState
    {
        public OverdrawnState(decimal balance, BankAccount bankAccount) { 
            Balance = balance;
            BankAccount = bankAccount;
        }
        public override void Deposit(decimal amount)
        {
            Balance += amount;
            Console.WriteLine($"Deposited {amount}$");

            if (Balance >= 0)
                BankAccount.AccountState = new RegularState(Balance, BankAccount);
        }

        public override void Withdraw(decimal amount)
        {
            Console.WriteLine($"Overdrawen: Can't Withdraw {amount}$. Balance is {Balance}$.");
        }
    }
}
