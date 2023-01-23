namespace Decorator.Pattern
{
    public abstract class MailServiceDecoratorBase : IMailService
    {
        private readonly IMailService _mailService;
        public MailServiceDecoratorBase(IMailService mailService)
        {
            _mailService = mailService;
        }
        public virtual void Send(string email, string mailString)
        {
            _mailService.Send(email, mailString);
        }
    }
}
