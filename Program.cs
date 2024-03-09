
using DataAnnonations;

var product = new Product
{
    Name = null,
    Price = -1,
    CreatedDate = DateTime.Now.AddDays(1),
    LastModifiedDate = DateTime.Now,
};

var results = product.Validate();
foreach (var result in results) Console.WriteLine($"{result.PropertyName}: {result.Value}");

Console.WriteLine("-----------------------------");

var user = new User
{
    Name = "ab",
    Email = "ca.co",
    Password = "123",
    ConfirmPassword = "12"
};

results = user.Validate();
foreach (var result in results) Console.WriteLine($"{result.PropertyName}: {result.Value}");

Console.ReadKey();
