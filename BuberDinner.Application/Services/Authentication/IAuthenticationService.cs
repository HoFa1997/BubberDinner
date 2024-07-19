namespace BuberDinner.Application.Services.Authentication;

public interface IAuthenticationService
{
    AuthenticationResult RegisterAsync(
        string Email,
        string Password,
        string FirstName,
        string LastName
    );
    AuthenticationResult LoginAsync(string Email, string Password);
}
