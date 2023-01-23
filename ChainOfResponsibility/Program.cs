using ChainOfResponsibility.Pattern;

var handler = new UserNameValidationHandler()
        .SetNext(new UserAgeValidationHandler());

var user = new User
{
    Name = "Mostafa",
    Age = 17,
    SocialSecuirtyNumber = "9245 2425 2563 XXXX"
};

try
{
    handler.Handle(user);
} catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}

user.Age = 21;

handler.Handle(user);