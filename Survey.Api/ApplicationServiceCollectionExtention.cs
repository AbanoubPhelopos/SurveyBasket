using Microsoft.EntityFrameworkCore;
using Survey.Application.Data;

namespace Survey.Api
{
    public static class ApplicationServiceCollectionExtension
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddControllers();

            // Properly chaining Swagger and other services
            services.AddEndpointsApiExplorer()
                .AddSwaggerGen()
                .AddApplicationDependencies()
                .AddDataBaseConfig(configuration);  // Pass configuration here
            
            return services;
        }

        private static IServiceCollection AddApplicationDependencies(this IServiceCollection services)
        {
            // Registering services and FluentValidation dependencies
            services.AddScoped<IPollServices, PollServices>();

            services.AddFluentValidationAutoValidation()  // Ensure FluentValidation setup
                .AddValidatorsFromAssembly(typeof(CreatePollRequestValidation).Assembly);
            
            return services;
        }

        private static IServiceCollection AddDataBaseConfig(this IServiceCollection services, IConfiguration configuration)
        {
            // Use the configuration to get the connection string
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseNpgsql(configuration.GetConnectionString("Default")));

            return services;
        }
    }
}