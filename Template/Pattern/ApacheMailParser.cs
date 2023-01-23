namespace Template.Pattern
{
    public class ApacheMailParser : MailParser
    {
        public override void AuthenticateToServer()
        {
            Console.WriteLine("Connecting to apache server...");
        }
    }
}
