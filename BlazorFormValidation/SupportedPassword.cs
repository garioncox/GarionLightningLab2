using System.ComponentModel.DataAnnotations;

namespace BlazorFormValidation;

public class SupportedPassword : ValidationAttribute
{
    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    {
        var password = (string)value;
        if (password == "password123")
        {
            return new ValidationResult("You cannot use the insecure password 'password123'.", new[] { validationContext.MemberName });
        }

        return ValidationResult.Success!;
    }
}
