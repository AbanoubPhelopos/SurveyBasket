using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Survey.Application.Data.EntityConfigrations;

public class ApplicationUserConfig : IEntityTypeConfiguration<ApplicationUser>
{
    public void Configure(EntityTypeBuilder<ApplicationUser> builder)
    {
        builder.Property(u => u.FristName).HasMaxLength(100);
        builder.Property(u => u.LastName).HasMaxLength(100);

    }
}