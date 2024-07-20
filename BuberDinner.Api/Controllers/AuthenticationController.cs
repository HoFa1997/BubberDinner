using BuberDinner.Application.Services.Authentication;
using BuberDinner.Contracts.Authentication;
using Microsoft.AspNetCore.Mvc;

namespace BuberDinner.Api.Controllers;

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
            authResult.user.Id,
            authResult.user.Email,
            authResult.user.FirstName,
            authResult.user.LastName,
            authResult.Token
        );
        return Ok(response);
    }

    [HttpPost("login")]
    public IActionResult Login(LoginRequest request)
    {
        var authResult = _authenticationService.LoginAsync(request.Email, request.Password);

        var response = new AuthenticationResponse(
            authResult.user.Id,
            authResult.user.Email,
            authResult.user.FirstName,
            authResult.user.LastName,
            authResult.Token
        );
        return Ok(response);
    }
}
