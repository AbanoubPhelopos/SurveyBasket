namespace Survey.Api.Services;

public interface IAuthServices
{
    Task<AuthResponse?> GetTokenAsync(string email,string password, CancellationToken cancellationToken=default);
}