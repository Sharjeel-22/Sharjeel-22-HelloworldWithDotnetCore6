namespace HelloWorld.Application.Service.Authentication;

public record AuthenticationResult(
    Guid Guid,
    string firstName,
    string lastName,
    string email,
    string password,
    string token
);
