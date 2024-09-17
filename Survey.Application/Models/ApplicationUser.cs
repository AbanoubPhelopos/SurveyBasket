using Microsoft.AspNetCore.Identity;

namespace Survey.Application.Models;

public sealed class ApplicationUser : IdentityUser
{
    public string FristName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;

}