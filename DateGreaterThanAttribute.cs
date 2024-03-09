using System.ComponentModel.DataAnnotations;

namespace DataAnnonations
{
    public class DateGreaterThanAttribute : ValidationAttribute
    {
        private readonly string propertyName;

        public DateGreaterThanAttribute(string propertyName)
        {
            this.propertyName = propertyName;
        }

        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            var comparisonDate = (DateTime)validationContext.ObjectType.GetProperty(propertyName)
                .GetValue(validationContext.ObjectInstance);

            return (DateTime)value > comparisonDate ?
                ValidationResult.Success :
                new ValidationResult(ErrorMessage = $"The {validationContext.DisplayName} must be greater than {propertyName}",
                [validationContext.MemberName]);
        }
    }
}
