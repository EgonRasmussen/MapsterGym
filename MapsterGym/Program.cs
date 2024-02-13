using Mapster;

internal class Program
{
    private static void Main()
    {
        User source = new User
        {
            FirstName = "John",
            LastName = "Doe"
        };



        // Map to existing instance
        UserDto destination1 = new();

        TypeAdapterConfig<User, UserDto>
            .NewConfig()
            .Map(dest => dest.FullName, src => $"{src.FirstName} {src.LastName}");
        source.Adapt(destination1);
    }
}

public class User
{
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
}

public class UserDto
{
    public string FullName { get; set; } = null!;
}