using Mapster;

internal class Program
{
    private static void Main()
    {
        UserDto destination = new UserDto
        {
            EmailAddress = "johndoe@gmail.com"
        };

        // Mapping from dto to source. The only new thing here is the TwoWays method.

        //TypeAdapterConfig<User, UserDto>
        //    .NewConfig()
        //    .TwoWays()
        //    .Map(dest => dest.EmailAddress, src => src.Email);

        User source = destination.Adapt<User>();        // From UserDto to User

        UserDto destination2 = source.Adapt<UserDto>(); // From User to UserDto
    }
}

public class User
{
    [AdaptMember("EmailAddress")]
    public string Email { get; set; } = null!;
}


public class UserDto
{
    public string EmailAddress { get; set; } = null!;
}