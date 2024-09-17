using Microsoft.EntityFrameworkCore;

namespace Survey.Application.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    { }

    public DbSet<Poll> Polls => Set<Poll>();
    
}