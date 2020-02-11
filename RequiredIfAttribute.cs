using System.ComponentModel.DataAnnotations;
using dojosurvey.Models;
namespace dojosurvey
{
    public class RequiredIfAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    {
        var survey = (Survey)validationContext.ObjectInstance;
        if (survey.Comment == null || survey.Comment.Length >= 20)
        {
            return ValidationResult.Success;
        }
        return new ValidationResult("Comment must be 20 characters long or more.");
    }
    
    }
}