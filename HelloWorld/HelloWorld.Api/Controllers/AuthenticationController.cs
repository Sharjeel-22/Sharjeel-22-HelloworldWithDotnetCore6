using HelloWorld.Application.Service.Authentication;
using HelloWorld.Contracts.Authentication;
using Microsoft.AspNetCore.Mvc;

namespace HelloWorld.Api.Controllers;

[ApiController]
[Route("auth")]
public class AuthenticationController : ControllerBase
{
    private readonly IAuthenticationService _auhenticationService;
    public AuthenticationController(IAuthenticationService authenticationService)
    {
        _auhenticationService = authenticationService;
    }
    [HttpPost("register")]
    public IActionResult Register(RegisterRequest request)
    {
        var authResults = _auhenticationService.Register(request.FirstName, request.LastName, request.Email, request.Password);
        return Ok(authResults);
    }
    [HttpPost("login")]
    public IActionResult Login(LoginRequest request)
    {
        var authResult = _auhenticationService.Login(request.Email, request.Password);
        return Ok(request);
    }
}