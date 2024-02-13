using Mapster;

internal class Program
{
    private static void Main()
    {
        User source = new User
        {
            Address = new Address
            {
                ZipCode = "12345"
            },

            FirstName = "John",
            LastName = "Doe"
        };

        // In object flattening, we can map the nested properties to the top-level properties using a simple naming convention (Toplevelname + Sublevelname = "Address"+"ZipCode").
        // 1. For instance, the Address.ZipCode nested property from the User source type can be mapped to AddressZipCode property in the UserDto destination type.
        // 2. The FullName property in the UserDto destination type can be mapped to the GetFullName method in the User source type.

        UserDto destination = source.Adapt<UserDto>();  
    }
}

public class User
{
    public Address Address { get; set; } = null!;               // 1.

    public string FirstName { get; set; } = null!;              // 2.
    public string LastName { get; set; } = null!;               // 2.
    public string GetFullName() => $"{FirstName} {LastName}";   // 2.
}

public class Address
{
    public string ZipCode { get; set; } = null!;                // 1.
}

public class UserDto
{
    public string AddressZipCode { get; set; } = null!;         // 1.

    public string FullName { get; set; } = null!;               // 2.
}