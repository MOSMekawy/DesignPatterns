namespace ChainOfResponsibility.Pattern
{
    public class UserNameValidationHandler : Handler<User>
    {
        public override void Handle(User request)
        {
            if (string.IsNullOrWhiteSpace(request.Name) || request.Name.Length <= 1) throw new ValidationFailedException("Invalid user name.");

            base.Handle(request);
        }
    }
}
