using System.ComponentModel.DataAnnotations;
using FluentValidation;
using FluentValidation.Validators;

namespace TestZone.Email;

public class ValidationMethods
{
    private static readonly EmailAddressAttribute _emailValidator = new();

    [Theory]
    [InlineData("mail@mail.com", true)]
    [InlineData("mail@mail@mail.com", false)]
    [InlineData("@mail.com", false)]
    [InlineData("mail@mail", false)]
    [InlineData("mail@.mail", false)]
    [InlineData("mail@mail.com.br", true)]
    public void EmailAttribute_ShouldValidate_TestCases(string email, bool valid)
    {
        _emailValidator.IsValid(email).ShouldBe(valid);
    }

    [Theory]
    [InlineData("mail@mail.com", true)]
    [InlineData("mail@mail@mail.com", false)]
    [InlineData("@mail.com", false)]
    [InlineData("mail@mail", false)]
    [InlineData("mail@.mail", false)]
    [InlineData("mail@mail.com.br", true)]
    public void FluentValidation_ShouldValidate_TestCases(string email, bool valid)
    {
        var validator = new EmailFluentValidator();
        validator.Validate(email).IsValid.ShouldBe(valid);
    }
}

public class EmailFluentValidator : AbstractValidator<string>
{
    public EmailFluentValidator()
    {
        RuleFor(email => email)
            .EmailAddress(EmailValidationMode.Net4xRegex);
    }
}
