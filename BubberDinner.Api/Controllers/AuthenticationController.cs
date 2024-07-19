using BubberDinner.Application.Services.Authentication;
using BubberDinner.Contracts.Authentication;
using Microsoft.AspNetCore.Mvc;

namespace BubberDinner.Api.Controllers;

[ApiController]
[Route("auth")]
public class AuthenticationController(IAuthenticationService _authenticationService)
    : ControllerBase
{
    [HttpPost("register")]
    public IActionResult Register(RegisterRequest request)
    {
        var authResult = _authenticationService.RegisterAsync(
            request.Email,
            request.Password,
            request.FirstName,
            request.LastName
        );

        var response = new AuthenticationResponse(
            authResult.Id,
            authResult.Email,
            authResult.Token,
            authResult.FirstName,
            authResult.LastName
        );
        return Ok(response);
    }

    [HttpPost("login")]
    public IActionResult Register(LoginRequest request)
    {
        var authResult = _authenticationService.LoginAsync(request.Email, request.Password);

        var response = new AuthenticationResponse(
            authResult.Id,
            authResult.Email,
            authResult.Token,
            authResult.FirstName,
            authResult.LastName
        );
        return Ok(response);
    }
}
