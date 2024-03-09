using System.ComponentModel.DataAnnotations;

namespace DataAnnonations
{
    public class Product
    {
        [Required(ErrorMessage = "The {0} is required")] public string Name { get; set; }
        [Range(0, 1000)] public decimal Price { get; set; }
        public DateTime CreatedDate { get; set; }
        [DateGreaterThan("CreatedDate")] public DateTime LastModifiedDate { get; set; }
    }

    public class User
    {
        [StringLength(16, MinimumLength = 4)] public string Name { get; set; }
        [Display(Name = "Email Address")][DataType(DataType.EmailAddress)][EmailAddress] public string Email { get; set; }
        [Required] public string Password { get; set; }
        [Compare("Password", ErrorMessage = "Passwords must match")] public string ConfirmPassword { get; set; }
    }

    public class ErrorMessage
    {
        public string Value { get; set; }
        public string PropertyName { get; set; }
    }
}
