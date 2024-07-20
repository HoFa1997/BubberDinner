using BuberDinner.Application.Common.Interfaces.Authentication;

namespace BuberDinner.Application.Services.Authentication;

public class AuthenticationService : IAuthenticationService
{
    private readonly IJwtTokenGenerator _jwtTokenGenerator;

    public AuthenticationService(IJwtTokenGenerator jwtTokenGenerator)
    {
        _jwtTokenGenerator = jwtTokenGenerator;
    }

    public AuthenticationResult RegisterAsync(
        string email,
        string password,
        string firstName,
        string lastName
    )
    {
        // Check if the email is already registered

        // Create User

        // Generate Token

        var userId = Guid.NewGuid();
        var token = _jwtTokenGenerator.GenerateToken(userId, firstName, lastName);

        return new AuthenticationResult(userId, firstName, lastName, email, token);
    }

    public AuthenticationResult LoginAsync(string email, string password)
    {
        // Check if the email is already registered

        // Create User

        // Generate Token

        var userId = Guid.NewGuid();
        var token = _jwtTokenGenerator.GenerateToken(userId, "first name", "last name");

        return new AuthenticationResult(userId, "first name", "last name", "email", token);
    }
}
