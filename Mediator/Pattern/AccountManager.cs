namespace Mediator.Pattern
{
    public class AccountManager : TeamMember
    {
        public AccountManager(string name) : base(name) { }
        public override void Receive(string from, string message)
        {
            Console.WriteLine($"{nameof(AccountManager)} {Name} received message: {message}");
            base.Receive(from, message);
        }
    }
}
