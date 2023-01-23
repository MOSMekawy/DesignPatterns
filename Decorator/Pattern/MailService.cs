namespace Decorator.Pattern
{
    public class MailService : IMailService
    {
        public void Send(string email, string mailString)
        {
            Console.WriteLine($"An email was sent to email ${email} with payload --- {mailString}");
        }
    }
}
