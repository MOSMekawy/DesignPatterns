namespace ChainOfResponsibility.Pattern
{
    public class UserAgeValidationHandler : Handler<User>
    {
        public override void Handle(User request)
        {
            if (request.Age < 18) throw new ValidationFailedException("User must be at least 18 years old.");

            base.Handle(request);
        }
    }
}
