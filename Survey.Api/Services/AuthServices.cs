using Microsoft.AspNetCore.Identity;

namespace Survey.Api.Services;

public class AuthServices(UserManager<ApplicationUser> userManager) : IAuthServices
{
    private readonly UserManager<ApplicationUser> _userManager = userManager;
    
    public async Task<AuthResponse?> GetTokenAsync(string email, string password, CancellationToken cancellationToken = default)
    {
        var user = await _userManager.FindByEmailAsync(email);
        if (user is null)
            return null;

        var isCorrectPass = await _userManager.CheckPasswordAsync(user, password);
        if (!isCorrectPass)
            return null;
        
        return new AuthResponse(Guid.NewGuid().ToString(),email,"abanoub","pop","akjkasdjk",3600 );
    }
}