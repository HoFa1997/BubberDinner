namespace BubberDinner.Contracts.Authentication;

public record AuthenticationResponse(
    Guid Id,
    string Email,
    string Token,
    string FirstName,
    string LastName
);
