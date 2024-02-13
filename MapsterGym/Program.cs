using Mapster;

internal class Program
{
    private static void Main()
    {
        User source = new User
        {
            Id = 1,
            Name = "User 1",
            Email = "test@example.com",
            IsActive = true,
            CreatedAt = DateTime.Now,
            Address = new Address
            {
                AddressLine1 = "Address Line 1",
                AddressLine2 = "Address Line 2",
                City = "City",
                State = "State",
                Country = "Country",
                ZipCode = "ZipCode"
            }
        };

        // Create new instance of UserDto and map the properties from source to destination
        // Simple Type Mapping: Konverterer typen for CreatedAt fra DateTime til string
        // Nested Type Mapping: Konverterer Address til Address
        UserDto destination = source.Adapt<UserDto>();  

        // Map to existing instance
        UserDto destination1 = new();
        source.Adapt(destination1);
    }
}

public class User
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public bool IsActive { get; set; }
    public string Email { get; set; } = null!;
    public DateTime CreatedAt { get; set; }
    public Address Address { get; set; } = null!;
}

public class UserDto
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public bool IsActive { get; set; }
    public string Email { get; set; } = null!;
    public string CreatedAt { get; set; } = null!;
    public Address Address { get; set; } = null!;
}

public class Address
{
    public string AddressLine1 { get; set; } = null!;
    public string AddressLine2 { get; set; } = null!;
    public string City { get; set; } = null!;
    public string State { get; set; } = null!;
    public string Country { get; set; } = null!;
    public string ZipCode { get; set; } = null!;
}