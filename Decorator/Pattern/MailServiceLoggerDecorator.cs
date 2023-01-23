namespace Decorator.Pattern
{
    public class MailServiceLoggerDecorator : MailServiceDecoratorBase
    {
        private readonly ILogger _logger;
        public MailServiceLoggerDecorator(IMailService mailService, ILogger logger) : base(mailService)
        {
            _logger = logger;
        }

        public override void Send(string email, string mailString)
        {
            _logger.Log($"Logging behavior added using decorator. Email is {email} & message is {mailString}.");

            base.Send(email, mailString);
        }
    }
}
