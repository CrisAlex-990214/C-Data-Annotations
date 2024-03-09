using System.ComponentModel.DataAnnotations;

namespace DataAnnonations
{
    public static class GenericValidator
    {
        public static IEnumerable<ErrorMessage> Validate<T>(this T entity)
        {
            var results = new List<ValidationResult>();

            var isValid = Validator.TryValidateObject(entity, new(entity), results, true);

            if (!isValid)
            {
                foreach (var result in results)
                {
                    yield return new()
                    {
                        Value = result.ErrorMessage,
                        PropertyName = result.MemberNames.FirstOrDefault()
                    };
                }
            }
        }
    }
}
