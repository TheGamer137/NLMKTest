using System.ComponentModel.DataAnnotations;

namespace NLMKTest.Services;

[AttributeUsage(AttributeTargets.Property)]
public class DateGreaterThanAttribute : ValidationAttribute
{
    public DateGreaterThanAttribute(string dateToCompareToFieldName)
    {
        DateToCompareToFieldName = dateToCompareToFieldName;
    }

    private string DateToCompareToFieldName { get; }

    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    {
        DateTime earlierDate = (DateTime)value;

        DateTime laterDate = (DateTime)validationContext.ObjectType.GetProperty(DateToCompareToFieldName).GetValue(validationContext.ObjectInstance, null);

        if (laterDate > earlierDate)
        {
            return ValidationResult.Success;
        }
        return new ValidationResult("Начало не может быть равно или позже конца простоя");
    }
}