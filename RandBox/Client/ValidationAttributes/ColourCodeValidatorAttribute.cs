using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace RandBox.Client.ValidationAttributes
{
    public class ColourCodeValidatorAttribute : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            Regex regex = new Regex(@"^(#)([0-9A-F]{6})$", RegexOptions.IgnoreCase);

            if (regex.IsMatch(value!.ToString()!))
            {
                return ValidationResult.Success;
            }

            return new ValidationResult("Invalid hex colour code", new[] { validationContext.MemberName }!);
        }
    }
}
