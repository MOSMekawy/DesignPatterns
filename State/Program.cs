using State.Pattern;

var banckAccount = new BankAccount();

banckAccount.Deposit(200);
banckAccount.Withdraw(400);
banckAccount.Withdraw(500);
banckAccount.Withdraw(400);
