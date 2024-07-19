namespace BuberDinner.Application.Services.Authentication;

public class AuthenticationService : IAuthenticationService
{
    public AuthenticationResult RegisterAsync(
        string email,
        string password,
        string firstName,
        string lastName
    )
    {
        return new AuthenticationResult(Guid.NewGuid(), firstName, lastName, email, "token");
    }

    public AuthenticationResult LoginAsync(string Email, string Password)
    {
        return new AuthenticationResult(
            Guid.NewGuid(),
            "first name",
            "last name",
            "email",
            "token"
        );
    }
}
